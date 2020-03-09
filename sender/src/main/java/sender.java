import javax.mail.MessagingException;
import java.io.IOException;
import java.security.GeneralSecurityException;
import java.sql.*;
import java.util.ArrayList;

public class sender {
    private static api api;
    private static String message;
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
            api = new api();

            //load the listeners from the database
            listeners = retrieveListeners(args[0], args[1]);

            //start sharing the link to emails
            sendEmails(args[2]);
        } catch (GeneralSecurityException | IOException e) {
            e.printStackTrace();
        }
    }//end main

    private static void sendEmails(String link) {
        for (Listener listener : listeners) {
            setMessageWithName(listener.getName(), "Here is the latest installment into the Email Ministry.\n\nEnjoy.", link);
            sendEmail(listener, "Email Ministry", message);
        }
    }

    private static void sendEmail(Listener listener, String subject, String message) {
        try {
            System.out.println(api.sendMessage("me", listener.getEmail(), "me", subject, message));
        } catch (IOException | MessagingException ex) {
            ex.printStackTrace();
        }
    }

    private static void setMessageWithName(String name, String messageBody, String link) {
        /* TODO: Add functionality to enter the message that dad wants it to say*/
        message = String.format("Good Afternoon %s,\n\n%s\n\n%s\n\nRemember, We Love You and Ain't Nothing You Can Do About It.", name, messageBody, link);
    }



    public static ArrayList<Listener> retrieveListeners(String userID, String password) {
        //creating a select query
        ResultSet myReader;
        ArrayList<Listener> listeners = new ArrayList<>();
        Listener listener;

        try (Connection myConn = DriverManager.getConnection(_connString, userID, password); Statement statement = myConn.createStatement()) {
            // Create and execute a SELECT SQL statement.
            String selectSql = "SELECT * FROM EMAIL_LISTENERS";
            myReader = statement.executeQuery(selectSql);

            // Print results from select statement
            while (myReader.next()) {
                listener = new Listener(myReader.getString(1), myReader.getString(2));
                listeners.add(listener);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return listeners;
    }//end retrieve listeners
}
