import java.sql.SQLException;

public class Main {
    public static void main(String[] args) {
        try {
            Connector.connect();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}

