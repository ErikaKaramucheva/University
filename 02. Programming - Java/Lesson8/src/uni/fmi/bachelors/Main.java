package uni.fmi.bachelors;

public class Main {

	public static void main(String[] args) {
		Pokemon p1=new Pokemon("pikachu",20,1000,40,2);
		Pokemon p2=new Pokemon("charmander",50,1600,15,0.9);

		p1.target=p2;
		p2.target=p1;
		
		p1.start();
		p2.start();
	}

}
