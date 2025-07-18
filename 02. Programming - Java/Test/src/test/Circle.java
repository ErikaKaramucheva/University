package test;

public class Circle extends Shape {

	public Circle(int a) {
		super(a);
	}

	@Override
	public double calculateArea() {
		return Math.PI*a*a;
	}

}
