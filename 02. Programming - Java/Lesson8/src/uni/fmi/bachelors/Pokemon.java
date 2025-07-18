package uni.fmi.bachelors;

import java.util.Random;

public class Pokemon extends Thread{

	String name;
	int power;
	int hp;
	int evadeChance;
	double attackSpeed;
	
	Pokemon target;//arraylist<pokemon> target;
	Random random=new Random();
	
	public Pokemon(String name, int power, int hp, int evadeChance, double attackSpeed) {
		super();
		this.name = name;
		this.power = power;
		this.hp = hp;
		this.evadeChance = evadeChance;
		this.attackSpeed = attackSpeed;
	}
	
	@Override
	public void run() {
		
		while(hp>0 && target.hp>0) {
			if(random.nextInt(101)>target.evadeChance) {
				target.hp-=power;
				System.out.println(name+" hit "+target.name+" for "+power+" points of demage and left him with "+target.hp+"hp.");
			}else {
				System.out.println(name+ " missed!");
			}
			
			try {
				sleep((long)(1000/attackSpeed));
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		
		if(hp>0) {
			System.out.println(name+ ": Hahaha loooseer!!!");
		}else {
			System.out.println(name+": CHEATEEEEERRR!!!!!!!");
		}
	}
	
}
