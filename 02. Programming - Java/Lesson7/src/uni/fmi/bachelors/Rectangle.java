package uni.fmi.bachelors;

public class Rectangle extends Shape{

	private double a;
	private double b;
	
	
	public Rectangle(String type, int numberOfSides, int a, int b) {
		super(type, numberOfSides);
		this.a=a;
		this.b=b;
	}

	@Override
	public double calculatePerimeter() {
		return 2*a+2*b;
	}

	@Override
	public double calculateArea() {
		return a*b;
	}

	public double getA() {
		return a;
	}

	public void setA(double a) {
		this.a = a;
	}

	public double getB() {
		return b;
	}

	public void setB(double b) {
		this.b = b;
	}

	
}
