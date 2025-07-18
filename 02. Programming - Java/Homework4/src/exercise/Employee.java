package exercise;

public abstract class Employee extends Person {
	
	protected int pNumber;
	protected String date;

	public Employee(String name, int age, int pNumber,String date) {
		super(name, age);
		this.pNumber=pNumber;
		this.date=date;
		
	}

	@Override
	public String toString() {
		return "Employee [pNumber=" + pNumber + ", date=" + date + ", name=" + name + ", age=" + age + "]";
	}

	public int getpNumber() {
		return pNumber;
	}

	public void setpNumber(int pNumber) {
		this.pNumber = pNumber;
	}

	public String getDate() {
		return date;
	}

	public void setD(String date) {
		this.date = date;
	}
	
	

	
}
