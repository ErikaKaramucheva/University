package uni.fmi.bachelors;

public class Person {

	public String name;
	private int age;
	protected String gender;
	String egn;//YYMMDDRRGC
	
	public Person(String name, String egn) {
		this.egn=egn;
		this.name=name;
	}
	
	public String getDoB() {
		String day= egn.substring(4, 6);
		String month=egn.substring(2,4);
		String year=egn.substring(0,2);
		return day+"/"+month+"/"+year;
		
	}
	
}
