package uni.fmi.bachelors;

public class MainClass {

	public static void main(String[] args) {
		
		Animal a1=new Animal("бозайник", 5);
		
		a1.setWeight(54500);
		
		a1.printInfo();
		double weight= a1.printWeightIn("кг");
		System.out.println("Weight in kg: "+weight);
		
		a1.setWeight(54000);
		double newWeight=a1.printWeightIn("кг");
		System.out.println("KG: "+newWeight);
		
		double pricePerKg=10.3;
		a1.setWeight(5000);
		System.out.println("KG: "+newWeight);
		
		System.out.println("Оборот: "+a1.printWeightIn("кг")*pricePerKg);

	}

}
