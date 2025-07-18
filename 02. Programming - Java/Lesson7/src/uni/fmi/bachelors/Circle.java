package uni.fmi.bachelors;

public class Circle extends Shape {
	
	private double r;

	public Circle(String type, int numberOfSides, double r) {
		super(type, numberOfSides);
		this.r=r;
	}

	@Override
	public double calculatePerimeter() {
		return 2*Math.PI*r;
	}

	@Override
	public double calculateArea() {
		return Math.PI*r;
	}

	public double getR() {
		return r;
	}

	public void setR(double r) {
		this.r = r;
	}

	
}
