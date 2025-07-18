package uni.fmi.bachelors;

public class ThreadExample implements Runnable{

	int counter;
	String name;
	
	public ThreadExample(int counter, String name) {
		this.counter=counter;
		this.name=name;
		}
	
	@Override
	public void run() {
		for(int i=0; i<counter;i++) {
			System.out.println(name+":"+ i);
		}
		
	}

}
