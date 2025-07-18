package Composition;

public class Developer implements Employee{
	
	private String name;
	private double salary;
	
	public Developer(String name, double salary) {
		this.name=name;
		this.salary=salary;
	}

	@Override
	public void add(Employee employee) {
		// Leaf node cannot add an employee
		
	}

	@Override
	public void remove(Employee employee) {
		// Leaf node cannot remove an employee
		
	}

	@Override
	public void printEmployeeInfo() {
		
		System.out.println("Name: "+name+ ", Salary: "+salary);
	}
	
	public String getName(){
		return this.name;
	}
	public double getSalary() {
		return this.salary;
	}
	

}
