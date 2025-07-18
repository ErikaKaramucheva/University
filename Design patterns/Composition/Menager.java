package Composition;

import java.util.ArrayList;
import java.util.List;

public class Menager implements Employee {

	private String name;
	private double salary;
	List<Employee> employees;
	
	public Menager(String name, double salary) {
		this.name=name;
		this.salary=salary;
		this.employees=new ArrayList<>();
	}
	@Override
	public void add(Employee employee) {
		this.employees.add(employee);
		
	}

	@Override
	public void remove(Employee employee) {
		this.employees.remove(employee);
		
	}
	public String getName() {
		return this.name;
	}
	public double getSalary() {
		return this.salary;
	}

	@Override
	public void printEmployeeInfo() {
		System.out.println("Name: "+name+", Salary: "+salary);
		for(Employee employee:this.employees) {
			employee.printEmployeeInfo();
		}
		
	}

}
