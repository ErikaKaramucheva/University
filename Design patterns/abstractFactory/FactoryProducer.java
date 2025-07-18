package abstractFactory;

public class FactoryProducer {
	public static AbstractFactory getFactory(String factoryName) {
		if(factoryName.equals("ColorFactory")) {
			return new ColorFactory();
		}
		if(factoryName.equals("ShapeFactory")) {
			return new ShapeFactory();
		}
		System.out.println("Unknown factory!");
		return null;
	}

}
