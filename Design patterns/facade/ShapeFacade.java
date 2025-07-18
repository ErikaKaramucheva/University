package facade;

public class ShapeFacade {

	private Circle circle;
	private Rectangle rectangle;
	public ShapeFacade() {
		this.circle = new Circle();
		this.rectangle = new Rectangle();
	}
	
	public void drawCircle() {
		this.circle.draw();
	}
	public void drawRectangle() {
		this.rectangle.draw();
	}
	
}
