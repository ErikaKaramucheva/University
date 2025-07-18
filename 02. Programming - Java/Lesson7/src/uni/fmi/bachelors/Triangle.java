package uni.fmi.bachelors;

public class Triangle extends Shape {

	private double a;
	private double b;
	private double c;
	private double ha;
	
	public Triangle(String type, int numberOfSides, double a, double b, double c, double ha) {
		super(type, numberOfSides);
		this.a=a;
		this.b=b;
		this.c=c;
		this.ha=ha;
	}

	@Override
	public double calculatePerimeter() {
		return a+b+c;
	}

	@Override
	public double calculateArea() {
		return a*ha/2;
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

	public double getC() {
		return c;
	}

	public void setC(double c) {
		this.c = c;
	}

	public double getHa() {
		return ha;
	}

	public void setHa(double ha) {
		this.ha = ha;
	}

	
}
