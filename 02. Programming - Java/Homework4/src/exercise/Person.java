package exercise;

public abstract class Person {
	protected String name;
	protected int age;

	public Person(String name, int age) {
		this.name=name;
		this.age=age;
	}

	public String toString() {
		return "Person [name=" + name + ", age=" + age + "]";
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

}
