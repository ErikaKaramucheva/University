package visitor;

public class VisitorMain {

	public static void main(String arg[]) {
		Product apple=new Fruit("Apple", 2.5,2);
		Product book = new Book( "The Witcher", 60);

        PriceCalculated calc = new PriceCalculated();
        double applePrice = apple.accept(calc);
        double bookPrice = book.accept(calc);
        //TODO use calculated values
        System.out.println(applePrice + bookPrice);
   

	}
}
