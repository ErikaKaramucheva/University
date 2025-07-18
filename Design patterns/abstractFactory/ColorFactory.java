package abstractFactory;

public class ColorFactory extends AbstractFactory {

	@Override
	Color getColor(String colorName) {
		if(colorName.equals("blue")) {
			return new Blue();
		}
		if(colorName.equals("green")) {
			return new Green();
		}
		System.out.println("Unknown color!");
		return null;
	}

	@Override
	Shape getShape(String shapeName) {
		System.out.println("Color factory cannot return shape!");
		return null;
	}

}
