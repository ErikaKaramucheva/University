package uni.fmi.bachelors;

public class Animal {

	private String type;
	private int age;
	private String color;
	private boolean isMale;
	private double weight;
	
	public double getWeight() {
		return weight;
	}
	
	public void setWeight(double weight) {
		if(weight<this.weight && this.weight-weight>1000) {
			System.err.println("Someone is trying something funcky....");
		}else {
		this.weight=weight; 
	}
		}
	
	public Animal(String type, int age) {
		this.type=type;
		this.age=age;
	}
	
	
	
	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public boolean isMale() {
		return isMale;
	}

	public void setMale(boolean isMale) {
		this.isMale = isMale;
	}

	public Animal(String type, int age, String color, boolean isMale, double weight) {
		this.type=type;
		this.age=age;
		this.color=color;
		this.isMale=isMale;
		this.weight=weight;
		
	}
	
	public void printInfo() {
		System.out.println("Type: "+type+ " Age: "+age+" Color: "+color+" isMale: "+ isMale+ " Weight: "+ weight);
		
	}
	//кг- паунд
	public double printWeightIn(String measure) {
		switch(measure) {
		case "кг":
			return weight/1000;
			
		case "паунд":
			return weight*0.0022;
		}
		return weight;
	}
	
	
	
}
