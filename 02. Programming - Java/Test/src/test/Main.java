package test;

import java.util.ArrayList;

public class Main {

	public static void main(String[] args) {
		//��������� ������ �� ����� �����:
		Triangle t1=new Triangle(4,2.5);
		Triangle t2=new Triangle(7,3.4);		
		Triangle t3=new Triangle(2,2);	
		
		Circle c1=new Circle(3);
		Circle c2=new Circle(6);
		Circle c3=new Circle(10);
		
		//�������� ���� ���� ��������� � �������� ���������� ����� � ���.
		ArrayList<Shape> shape=new ArrayList<>();
		shape.add(t1);
		shape.add(t2);
		shape.add(t3);
		shape.add(c1);
		shape.add(c2);
		shape.add(c3);
		
		//�������� ���������� �������� �� ������ �� �����������, ������ ����� �� ���������� �������
		double maxArea=0;
		for(int i=0;i<shape.size();i++) {
			if(shape.get(i) instanceof Triangle) {
				Triangle temp=(Triangle)shape.get(i);
				if(temp.calculateArea()>maxArea) {
					maxArea=temp.calculateArea();
				}			
			}
		}
		System.out.println("������������ ���� �� ����������� �: "+maxArea);
		
		//Triangle example=null;
		//for(int i=0;i<shape.size();i++) {
			//if(shape.get(i) instanceof Triangle) {
				//if(shape!=null && shape.get(i).calculateArea()>example.calculateArea()) {
					//example=(Triangle)shape.get(i);
				//}else {
					//example=(Triangle)shape.get(i);
				//}
			//}
		//}System.out.println(example.calculateArea());
		
		//�������� �������������� ��������, ������ ����� �� ��������� �������� � ���-������� ����
		double minArea=1000000000;
		for(int i=0;i<shape.size();i++) {
			if(shape.get(i).calculateArea()<minArea) {
				minArea=shape.get(i).calculateArea();		
			}
		}
		
		System.out.println("����������� ���� �� ������ ��������� �: "+minArea);
		
	}

}
