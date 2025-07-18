package proxy;

public class ProxyMain {

	public static void main(String[] args) {
		Image image1=new ProxyImage("hi");
		image1.render();
		image1.render();

	}

}
