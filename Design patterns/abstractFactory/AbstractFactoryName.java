package abstractFactory;

public class AbstractFactoryName {

	public static void main(String[] args) {
		AbstractFactory shapeFactory=FactoryProducer.getFactory("ShapeFactory");
		Shape shape=shapeFactory.getShape("circle");
		shape.draw();
		
		AbstractFactory colorFactory=FactoryProducer.getFactory("ColorFactory");
		Color color=colorFactory.getColor("blue");
		color.fill();

	}

}
