package first;

public abstract class Shape {

	int length;
	int breadth;
	public Shape(int length, int breadth) {
		this.length=length;
		this.breadth=breadth;
	}
	public abstract int Area();
	public int getLength() {
		return length;
	}
	public void setLength(int length) {
		this.length = length;
	}
	public int getBreadth() {
		return breadth;
	}
	public void setBreadth(int breadth) {
		this.breadth = breadth;
	}	
	
}
