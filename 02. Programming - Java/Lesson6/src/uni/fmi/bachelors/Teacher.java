package uni.fmi.bachelors;

public class Teacher extends Person {

	private int numberOfClasses;
	private int numberOfGroups;
	private double payPerHour;
	
	public Teacher(String name, String egn, int numberOfClasses, int numberOfGroups, double payPerHour) {
		super(name, egn);
		this.numberOfClasses=numberOfClasses;
		this.numberOfGroups=numberOfGroups;
		this.payPerHour=payPerHour;
	}
	
	public double calculateTeacherPay() {
		double payment=numberOfClasses*numberOfGroups*payPerHour;
		return payment;
	}

}
