import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class Connector {

    public static void connect() throws SQLException {
        String dbUrl = "jdbc:mysql://localhost:3306/auth_un?useSSL=false";
        String password = "pass";
        String username = "root";

        String query = "CREATE TABLE IF NOT EXISTS `users` (" +
                "`u_id` int(11) NOT NULL AUTO_INCREMENT, " +
                "`u_login` varchar(255) NOT NULL, " +
                "`u_password` char(40) NOT NULL, " +
                "`u_email` varchar(255) NOT NULL, " +
                "`u_name` varchar(255) NOT NULL, " +
                "`u_remember` char(40) NOT NULL, PRIMARY KEY (`u_id`)" +
                ") ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;";

        Connection connection = DriverManager.getConnection(dbUrl, username, password);
        Statement statement = connection.createStatement();
        statement.executeUpdate(query);

/*
        query = "INSERT INTO `users` (`u_id`, `u_login`, `u_password`, `u_email`, `u_name`, `u_remember`) " +
                "VALUES (1, 'user1', 'e38ad214943daad1d64c102faec29de4afe9da3d', 'user1@mail.com', 'Pupkin', ''), " +
                "(2, 'user2', '2aa60a8ff7fcd473d321e0146afd9e26df395147', 'user2@mail.com', 'Smith', ''); ";
*/

        query = "INSERT INTO `users` (`u_login`, `u_password`, `u_email`, `u_name`, `u_remember`) " +
                "VALUES ('user1', 'e38ad214943daad1d64c102faec29de4afe9da3d', 'user1@mail.com', 'Pupkin', ''), " +
                "('user2', '2aa60a8ff7fcd473d321e0146afd9e26df395147', 'user2@mail.com', 'Smith', ''); ";


        statement.executeUpdate(query);
    }

}
