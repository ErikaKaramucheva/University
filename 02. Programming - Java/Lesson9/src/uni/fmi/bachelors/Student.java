package uni.fmi.bachelors;

public class Student extends Person {

	private double average;
	
	public Student(String name, String gender, String EGN, double average) {
		super(name, gender, EGN);
		this.average=average;
		
	}

	public double getAverage() {
		return average;
	}

	public void setAverage(double average) {
		this.average = average;
	}

	
}
