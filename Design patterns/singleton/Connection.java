package singleton;

public class Connection {
	private static Connection instance;
	private Connection() {}
	
	public static Connection getInstance() {
	if(instance==null) {
		instance=new Connection();
	
	}
	return instance;
	}
	
	public void connect(String token) {
		System.out.println("Connecting with: "+token);
	}

}
