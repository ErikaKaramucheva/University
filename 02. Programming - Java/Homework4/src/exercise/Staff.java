package exercise;

public class Staff extends Employee {

	private String position;
	
	public Staff(String name, int age, int pNumber, String date, String position) {
		super(name, age, pNumber, date);
		this.position=position;
	}

	@Override
	public String toString() {
		return "Staff [position=" + position + ", pNumber=" + pNumber + ", date=" + date + ", name=" + name + ", age=" + age
				+ "]";
	}

	public String getPosition() {
		return position;
	}

	public void setPosition(String position) {
		this.position = position;
	}

	
}
