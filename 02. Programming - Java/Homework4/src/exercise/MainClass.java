package exercise;

public class MainClass {

	public static void main(String[] args) {
		Student student=new Student("Erika", 19, 2101321067,"Software Engineering");
		Staff staff=new Staff("Maria", 37, 10152410, "21/01/2018", "Secretary");
		Faculty faculty=new Faculty("Victoria", 45, 10131742, "03/07/2013", "Assistant");
		
		System.out.println(student);
		System.out.println(staff);
		System.out.println(faculty);
	}

}
