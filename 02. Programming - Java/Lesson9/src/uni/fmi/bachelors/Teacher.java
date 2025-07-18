package uni.fmi.bachelors;

public class Teacher extends Person {
	
	private int salary;

	public Teacher(String name, String gender, String EGN, int salary) {
		super(name, gender, EGN);
		this.salary=salary;
	}

	public int getSalary() {
		return salary;
	}

	public void setSalary(int salary) {
		this.salary = salary;
	}
	
	

}
