package test;

public class Triangle extends Shape {

	private double ha;
	public Triangle(int a, double ha) {
		super(a);
		this.ha=ha;
	}

	@Override
	public double calculateArea() {
		return a*ha/2;
	}

	public double getHa() {
		return ha;
	}

	public void setHa(double ha) {
		this.ha = ha;
	}

	
}
