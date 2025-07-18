package uni.fmi.bachelors;

public abstract class Shape {

	private String name;
	private int numberOfSides;
	private String type;

	public Shape(String type, int numberOfSides) {
		this.type = type;
		this.numberOfSides = numberOfSides;
	}

	public abstract double calculatePerimeter();

	public abstract double calculateArea();

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getNumberOfSides() {
		return numberOfSides;
	}

	public void setNumberOfSides(int numberOfSides) {
		this.numberOfSides = numberOfSides;
	}

	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

}
