package uni.fmi.bachelors;

import java.util.ArrayList;

public class MainClassShape {

	public static void main(String[] args) {
		Circle c=new Circle("circle", 0,13);
		Triangle t=new Triangle("triangle", 3, 3, 4, 5, 3.5);
		Rectangle r=new Rectangle("rectangle", 4, 5, 4);

		System.out.println("Circle P:"+c.calculatePerimeter()+" S:"+c.calculateArea());
		System.out.println("Triangle P: "+t.calculatePerimeter()+" S:"+t.calculateArea());
		System.out.println("Rectangle P: "+r.calculatePerimeter()+" S"+r.calculateArea());
	
		ArrayList<Shape> figures=new ArrayList<>();
		
		figures.add(c);
		figures.add(t);
		
		
		
		for(int i=0;i<figures.size();i++) {
			
			if(figures.get(i) instanceof Circle) {
				Circle temp=(Circle)figures.get(i);
				System.out.println(temp.getR());
				
				
			System.out.println( ((Circle)figures.get(i)).getR());
		}
			}
	}

}
