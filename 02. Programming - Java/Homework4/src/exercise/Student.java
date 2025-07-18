package exercise;

public class Student extends Person {
	
	private int fNumber;
	private String speciality;
	

	public Student(String name, int age, int fNumber, String speciality) {
		super(name, age);
		this.fNumber=fNumber;
		this.speciality=speciality;
		
	}


	@Override
	public String toString() {
		return "Student [name="+name+", age="+age+", facultyNumber=" + fNumber + ", speciality=" + speciality + "]";
	}


	public int getfNumber() {
		return fNumber;
	}


	public void setfNumber(int fNumber) {
		this.fNumber = fNumber;
	}


	public String getSpeciality() {
		return speciality;
	}


	public void setSpeciality(String speciality) {
		this.speciality = speciality;
	}
	
	

}
