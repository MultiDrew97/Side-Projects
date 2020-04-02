import javax.mail.MessagingException;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.security.GeneralSecurityException;
import java.sql.*;
import java.util.ArrayList;
import java.util.Scanner;

public class Sender {
    private static Api api;
    private static StringBuilder message = new StringBuilder("<html><head><style>p{font: normal larger \"Times New Roman\", sans-serif;}</style></head><body><p>Good Afternoon %s</p><br/>");
    private static ArrayList<Listener> listeners;
    private static final String _connString = "jdbc:sqlserver://mediaministry.database.windows.net:1433;" +
                                                "database=Media Ministry;" +
                                                "encrypt=true;" +
                                                "trustServerCertificate=false;" +
                                                "hostNameInCertificate=*.database.windows.net;" +
                                                "loginTimeout=30;";

    public static void  main(String... args) {
        try {
            //create the instance of the api connection
            api = new Api();

            //load the listeners from the database
            listeners = retrieveListeners(args[0], args[1]);

            loadMessage();
            //start sharing the link to emails
            sendEmails(args[2]);
        } catch (GeneralSecurityException | IOException e) {
            e.printStackTrace();
        }
    }//end main

    private static void sendEmails(String link) {
        for (Listener listener : listeners) {
            setMessageWithName(listener.getName(), "Here is the latest installment into the Email Ministry.\n\nEnjoy.", link);
            sendEmail(listener, message.toString());
        }
    }

    private static void sendEmail(Listener listener, String message) {
        try {
            api.sendMessage("me", listener.getEmail(), "me", "Email Ministry", message);
        } catch (IOException | MessagingException ex) {
            ex.printStackTrace();
        }
    }

    private static void setMessageWithName(String name, String messageBody, String link) {
        /* TODO: Add functionality to enter the message that dad wants it to say*/
        message = new StringBuilder(String.format(message.toString(), name, link));
    }



    public static ArrayList<Listener> retrieveListeners(String userID, String password) {
        //creating a select query
        ResultSet myReader;
        ArrayList<Listener> listeners = new ArrayList<>();
        //Listener listener;

        try (Connection myConn = DriverManager.getConnection(_connString, userID, password); Statement statement = myConn.createStatement()) {
            // Create and execute a SELECT SQL statement.
            String selectSql = "SELECT * FROM EMAIL_LISTENERS";
            myReader = statement.executeQuery(selectSql);

            // Print results from select statement
            while (myReader.next()) {
                //listener = new Listener(myReader.getString(1), myReader.getString(2));
                //listeners.add(listener);
                listeners.add(new Listener() {{
                    setName(myReader.getString(1));
                    setEmail(myReader.getString(2));
                }});
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return listeners;
    }//end retrieve listeners

    private static void loadMessage() {
        try (Scanner fin = new Scanner(new File("./target/classes/message.txt")) ) {
            while (fin.hasNextLine()) {
                message.append("<p>" + fin.nextLine() + "</p>");
            }

            message.append("<p><a href=\"%s\">This Weeks Lesson</a></p></body></html>");
        } catch (FileNotFoundException ex) {

        }
    }
}
