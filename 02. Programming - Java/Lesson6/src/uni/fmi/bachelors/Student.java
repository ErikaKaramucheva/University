package uni.fmi.bachelors;

public class Student extends Person{

	private String fn;
	private double averageGrade;
	private String specialty;
	
	public Student(String name, String egn) {
		super(name, egn);
		
	}

	public void calculateAverageGrade(int[] grades) {
		int total=0;
		for(int grade:grades) {
		total+=grade;
		}
		averageGrade=(double)total/grades.length;
		
	}
	
	@Override
	public String toString() {
		return "Student [fn=" + fn + ", averageGrade=" + averageGrade + ", specialty=" + specialty + "]"+super.toString();
	} 
	
}
