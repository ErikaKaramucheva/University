package uni.fmi.bachelors;

import java.util.ArrayList;

public class Main {

	public static void main(String[] args) {
		Student studentOne=new Student("Erika", "female","7727351016", 4.8);
		Student studentTwo=new Student("Maria","female","7654121199",5.4);
		Student studentThree=new Student("Ivan","male","8144562130",5.7);
		
		Teacher teacherOne=new Teacher("Peter","male","6654123418",1400);
		Teacher teacherTwo=new Teacher("Victoria","female","7341275511",3800);
		Teacher teacherThree=new Teacher("Nikola","male","6914112454",2600);
		
		double maxGrade=0;
		double result=studentOne.getAverage();
		
		
		ArrayList<Student> students=new ArrayList<>();
		students.add(studentOne);
		students.add(studentTwo);
		students.add(studentThree);
		
		for(int i=0;i<students.size();i++) {
			if(students.get(i).getGender()=="female") {
				if(students.get(i).getAverage()>maxGrade) {
					maxGrade=students.get(i).getAverage();		
					
				}
			
				if(maxGrade>=result) {
					System.out.println(students.get(i).getName()+" has the heighest grade: "+ maxGrade);
				}
		}

		}
		
			
		double averageSalary=(teacherOne.getSalary()+teacherTwo.getSalary()+teacherThree.getSalary())/3;
		
		System.out.println("The average salary of the three teachers is: "+ averageSalary);
	}

}

