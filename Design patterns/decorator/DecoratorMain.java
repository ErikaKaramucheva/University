package decorator;

public class DecoratorMain {

	public static void main(String[] args) {
		Car lada=new Lada();
		lada=new EngineDecorator(lada, "V8");
		lada= new ColorDecorator(lada, "Light blue");
		lada.create();
		
		Car audi=new Audi();
		audi=new ColorDecorator(audi, "Silver");
		audi.create();

	}

}
