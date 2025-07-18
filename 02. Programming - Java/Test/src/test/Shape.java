package test;

public abstract class Shape {

	protected int a;
	
	public Shape(int a) {
		this.a=a;
	}

	public abstract double calculateArea();
	
	public int getA() {
		return a;
	}

	public void setA(int a) {
		this.a = a;
	}

	
}
