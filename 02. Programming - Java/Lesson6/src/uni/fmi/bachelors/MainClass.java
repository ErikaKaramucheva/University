package uni.fmi.bachelors;

public class MainClass {

	public static void main(String[] args) {
		
		Student student=new Student("Ивелина","9511114536");
		Teacher teacher=new Teacher("Георги","8005044248",6,3, 4.5);
		
		student.calculateAverageGrade(new int[] {3,6,4,5,6,6,6,3});
		System.out.println(student.getDoB());
		System.out.println(student.toString());
		
		System.out.println(teacher.calculateTeacherPay());
		System.out.println(teacher.toString());
		
	}

}
