package uni;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DbContext {

static Connection conn=null;
	
	static Connection getConnection() {
		
		
		try {
			Class.forName("org.h2.Driver");
			conn=DriverManager.getConnection("jdbc:h2:C:\\Users\\user\\eclipse-workspace\\PharmacySystem\\DB;DB_CLOSE_ON_EXIT=TRUE","sa", "test");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return conn;
	}
}
