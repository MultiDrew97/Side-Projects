public class Listener {
    private String name;
    private String email;

    public Listener(String name, String email) {
        this.setName(name);
        this.setEmail(email);
    }

    public String getName() {
        return this.name;
    }
    public void setName(String name){
        this.name = name;
    }

    public String getEmail() {
        return this.email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
}
