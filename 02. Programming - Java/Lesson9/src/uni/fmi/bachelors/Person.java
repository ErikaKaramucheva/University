package uni.fmi.bachelors;

public abstract class Person {

	private String name;
	private String gender;
	private String EGN;
	
	public Person(String name, String gender, String EGN) {
		this.name=name;
		this.gender=gender;
		this.EGN=EGN;
		
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}

	public String getEGN() {
		return EGN;
	}

	public void setEGN(String eGN) {
		EGN = eGN;
	}
	
	

}
