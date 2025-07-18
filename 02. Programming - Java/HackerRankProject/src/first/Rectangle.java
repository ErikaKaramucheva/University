package first;

public class Rectangle extends Shape {

	public Rectangle(int length,int breadth) {
	super(length,breadth);
		
	}
	@Override
	public int Area() {

		return length*breadth;
	}

}
