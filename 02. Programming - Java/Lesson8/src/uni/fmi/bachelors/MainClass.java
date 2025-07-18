package uni.fmi.bachelors;

public class MainClass {

	public static void main(String[] args) {
		ThreadExample t1=new ThreadExample(1000,"T1");
		ThreadExample t2=new ThreadExample(1000,"T2");
		
		new Thread(t1).start();
		new Thread(t2).start();
		
	}

}
