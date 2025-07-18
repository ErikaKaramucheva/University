package Composition;

public class CompositeMain {

	public static void main(String[] args) {
		Menager man1=new Menager("The Boss",1000000);
		Menager man2=new Menager("Small Boss",10000);
		
		Developer dev1=new Developer("Ivan",1500);
		Developer dev2=new Developer("Maria", 750);
		
		man1.add(man2);
		man2.add(dev1);
		man2.add(dev2);

		man2.printEmployeeInfo();
		
		Menager man3=new Menager("Third Boss",8000);
		Developer dev3=new Developer("Georgi", 750);
		Developer dev4=new Developer("Gergana", 320);
		
		man2.add(man3);
		man3.add(dev3);
		man3.add(dev4);
		
		man3.remove(dev1);
		man2.printEmployeeInfo();
	}

}
