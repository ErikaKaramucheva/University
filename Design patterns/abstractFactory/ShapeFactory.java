package abstractFactory;

public class ShapeFactory extends AbstractFactory {

	@Override
	Color getColor(String colorName) {
		System.out.println("Shape factory cannot return color!");
		return null;
	}

	@Override
	Shape getShape(String shapeName) {
		if(shapeName.equals("rectangle")) {
			return new Rectangle();
		}
		if(shapeName.equals("circle")) {
			return new Circle();
		}
		return null;
	}

}
