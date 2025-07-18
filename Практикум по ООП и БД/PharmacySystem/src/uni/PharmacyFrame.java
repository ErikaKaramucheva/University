package uni;

import java.awt.Color;
import java.awt.Dialog;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.FocusEvent;
import java.awt.event.FocusListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JPopupMenu;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JTextField;


public class PharmacyFrame  extends JFrame{

	Connection conn=null;
	//Connection conn=DbConnection.getConnection();;
	PreparedStatement state=null;
	ResultSet result=null;
	
	int customId=-1;
	int medId=-1;
	int formId=-1;
	int catId=-1;
	double unit_price=0;
	int orderId=-1;
	String criteria="Търсене на клиент по телефон";
	String sql="";
	int c=-1;
	
	public PharmacyFrame()
	{
		conn=DbContext.getConnection();
		this.setVisible(true);
		this.setSize(800,600);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setTitle("Аптека \"Щастие\"");
		this.add(tab);
		this.refreshOrderTable();
		this.refreshFormTable();
		this.refreshCategoryCombo();
		this.refreshCustomCombo();
		this.refreshFormCombo();
		this.refreshDrugCombo();
		this.refreshCategoryTable();
		this.refreshCustomerTable();
		this.refreshDrugTable();
		//orderPanel
		tab.add(orderPanel,"Поръчка");
		//pillPanel
		tab.add(pillPanel,"Лекарства");
		
		//categoryPanel
		tab.add(categoryPanel,"Предназначение");	
		//formPanel
		tab.add(formPanel,"Форма");	
			
		
		//customerPanel
		tab.add(customerPanel,"Клиент");		
		
		//refPanel
		tab.add(refPanel,"Справки");		
		
		this.refresh();
	}
	
	JTabbedPane tab=new JTabbedPane();
	JPanel orderPanel=new JPanel();
	JPanel pillPanel=new JPanel();
	JPanel categoryPanel=new JPanel();
	JPanel customerPanel=new JPanel();
	JPanel formPanel=new JPanel();
	JPanel refPanel=new JPanel();
	
	//Buttons and Panels for Medicament Tab
		JPanel firstPillPanel=new JPanel();
		JPanel secondPillPanel=new JPanel();
		JPanel thirdPillPanel=new JPanel();
		
		JLabel pillName=new JLabel("Име на лекарство: ");
		JTextField setPillName=new JTextField();
		JLabel pillCategory=new JLabel("Категория: ");
		JComboBox<String> comboCategory=new JComboBox<String>();
		JLabel pillForm=new JLabel("Форма: ");
		JComboBox<String> comboForm=new JComboBox<String>();
		JLabel pillPrice=new JLabel("Цена на лекарство: ");
		JTextField setPillPrice=new JTextField();	
		
		JButton addPillBtn=new JButton( "Добави");
		JButton editPillBtn=new JButton( "Редактирай");
		JButton deletePillBtn=new JButton( "Изтрий");
		JButton searchPillBtn=new JButton( "Търсене");
		

		JTable pillTable=new JTable();
		JScrollPane pillScroll=new JScrollPane(pillTable);
		
		
		
	//Buttons and Panels for Category Tab
	JPanel firstCategoryPanel=new JPanel();
	JPanel secondCategoryPanel=new JPanel();
	JPanel thirdCategoryPanel=new JPanel();
	
	JLabel categoryName=new JLabel("Предназначение: ");
	JTextField setCategoryName=new JTextField();	
	
	JButton addCategoryBtn=new JButton( "Добави");
	JButton editCategoryBtn=new JButton( "Редактирай");
	JButton deleteCategoryBtn=new JButton( "Изтрий");
	JButton searchCategoryBtn=new JButton( "Търсене");
	

	JTable categoryTable=new JTable();
	JScrollPane categoryScroll=new JScrollPane(categoryTable);
	
	//Buttons and Panels for Form Tab
		JPanel firstFormPanel=new JPanel();
		JPanel secondFormPanel=new JPanel();
		JPanel thirdFormPanel=new JPanel();
		
		JLabel formName=new JLabel("Форма: ");
		JTextField setFormName=new JTextField();	
		
		JButton addFormBtn=new JButton( "Добави");
		JButton editFormBtn=new JButton( "Редактирай");
		JButton deleteFormBtn=new JButton( "Изтрий");
		JButton searchFormBtn=new JButton( "Търсене");
		

		JTable formTable=new JTable();
		JScrollPane formScroll=new JScrollPane(formTable);
		
		
		
	//Buttons and Panels for Customer
	JPanel firstCustomPanel=new JPanel();
	JPanel secondCustomPanel=new JPanel();
	JPanel thirdCustomPanel=new JPanel();
	
	JLabel firstCustomName=new JLabel("Име на клиента: ");
	JTextField setFirstCustomName=new JTextField();
	JLabel lastCustomName=new JLabel("Фамилия: ");
	JTextField setLastCustomName=new JTextField();
	JLabel customEmail=new JLabel("Имейл: ");
	JTextField setCustomEmail=new JTextField();
	JLabel customPhone=new JLabel("Телефон: ");
	JTextField setCustomPhone=new JTextField();
	
	JButton addCustomBtn=new JButton( "Добави");
	JButton editCustomBtn=new JButton( "Редактирай");
	JButton deleteCustomBtn=new JButton( "Изтрий");
	JButton searchCustomBtn=new JButton( "Търсене");
	

	JTable customerTable=new JTable();
	JScrollPane customerScroll=new JScrollPane(customerTable);
	
	//Buttons and Panels for OrderPanel
	JPanel firstOrderPanel=new JPanel();
	JPanel secondOrderPanel=new JPanel();
	JPanel thirdOrderPanel=new JPanel();
	
	JLabel customer=new JLabel("Клиент: ");
	JComboBox<String> comboCustomer=new JComboBox<String>();
	JLabel medicament=new JLabel("Лекарство: ");
	JComboBox<String> comboMedicament=new JComboBox<String>();
	JLabel quantity=new JLabel("Количество: ");
	JTextField setQuantity=new JTextField();
	JLabel price=new JLabel("Цена:");
	JTextField setPrice=new JTextField("*** Полето служи само за търсене на поръчки с цена над указаната");
	
	JButton addOrderBtn=new JButton( "Добави");
	JButton editOrderBtn=new JButton( "Редактирай");
	JButton deleteOrderBtn=new JButton( "Изтрий");
	JButton searchOrderBtn=new JButton( "Търсене");
	

	JTable orderTable=new JTable();
	JScrollPane orderScroll=new JScrollPane(orderTable);
	
	//Buttons and Panels for RefPanel
	JPanel firstRefPanel=new JPanel();
	JPanel news=new JPanel();
	JPanel secondRefPanel=new JPanel();
	JPanel thirdRefPanel=new JPanel();
	
	JLabel criterion=new JLabel("Изберете критерий, по който да търсите: ");
	String[] item= {"Търсене на клиент по телефон", "Търсене на клиент по имейл",
			"Търсене на лекарство по форма", "Търсене на лекарство по предназначение (област)",
			"Търсене на породукт по единична цена","Търсене на лекарство по предназначение и форма",
			"Търсене на продукт по цена и категория","Търсене на поръчка по клиент",
			"Търсене на поръчка по лекарство","Търсене на поръчка по лекарство и брой поръчвани продукти",
			"Търсене на поръчка по брой поръчани лекарства", "Търсене на поръчка по дефинирани клиент и лекарство"};
	JComboBox<String> comboCriterion=new JComboBox<String>(item);
	
	JButton searchRefBtn=new JButton( "Търсене");
	JButton submitBtn=new JButton( "Избери");
	
	
	
	JTable refTable=new JTable();
	JScrollPane refScroll=new JScrollPane(refTable);
	
	
	
	public void refreshOrderTable() {
		//conn=MyDBConnection.getConnection();
		String str="";
		str="select concat(customer.fname,\' \',customer.lname) as customer, "
				+ "drug.name as medicament_name,"
				+ " orders.quantity, total_price "
				+ "from orders, customer, drug "
				+ "where orders.customer_id=customer.id and orders.drug_id=drug.id";
		try {
			state=conn.prepareStatement(str);
			result=state.executeQuery();
			orderTable.setModel(new MyModel(result));
			
			orderTable.getColumnModel().getColumn(4).setMinWidth(0);
			orderTable.getColumnModel().getColumn(4).setMaxWidth(0);
			orderTable.getColumnModel().getColumn(4).setWidth(0);

			orderTable.getColumnModel().getColumn(4).setMinWidth(0);
			orderTable.getColumnModel().getColumn(4).setMaxWidth(0);
			orderTable.getColumnModel().getColumn(4).setWidth(0);

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public void refreshFormTable() {
		//conn=MyDBConnection.getConnection();
		String str="";
		str="select name from form ";
		try {
			state=conn.prepareStatement(str);
			result=state.executeQuery();
			formTable.setModel(new MyModel(result));
			
			formTable.getColumnModel().getColumn(1).setMinWidth(0);
			formTable.getColumnModel().getColumn(1).setMaxWidth(0);
			formTable.getColumnModel().getColumn(1).setWidth(0);

			formTable.getColumnModel().getColumn(1).setMinWidth(0);
			formTable.getColumnModel().getColumn(1).setMaxWidth(0);
			formTable.getColumnModel().getColumn(1).setWidth(0);

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void refreshCategoryTable() {
		//conn=MyDBConnection.getConnection();
		String str="";
		str="select name from category ";
		try {
			state=conn.prepareStatement(str);
			result=state.executeQuery();
			categoryTable.setModel(new MyModel(result));
			
			categoryTable.getColumnModel().getColumn(1).setMinWidth(0);
			categoryTable.getColumnModel().getColumn(1).setMaxWidth(0);
			categoryTable.getColumnModel().getColumn(1).setWidth(0);

			categoryTable.getColumnModel().getColumn(1).setMinWidth(0);
			categoryTable.getColumnModel().getColumn(1).setMaxWidth(0);
			categoryTable.getColumnModel().getColumn(1).setWidth(0);

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void refreshCustomerTable() {
		//conn=MyDBConnection.getConnection();
		String str="";
		str="select fname as first_name,lname as last_name, phone,email from customer ";
		try {
			state=conn.prepareStatement(str);
			result=state.executeQuery();
			customerTable.setModel(new MyModel(result));
			
			customerTable.getColumnModel().getColumn(4).setMinWidth(0);
			customerTable.getColumnModel().getColumn(4).setMaxWidth(0);
			customerTable.getColumnModel().getColumn(4).setWidth(0);

			customerTable.getColumnModel().getColumn(4).setMinWidth(0);
			customerTable.getColumnModel().getColumn(4).setMaxWidth(0);
			customerTable.getColumnModel().getColumn(4).setWidth(0);

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public void refreshDrugTable() {
		//conn=MyDBConnection.getConnection();
		String str="";
		str="select drug.name AS medicament_name, price, "
				+ "category.name AS category, "
				+ "form.name AS form "
				+ "from drug,category,form "
				+ "where drug.category_id=category.id and "
				+ "drug.form_id=form.id ";
		try {
			state=conn.prepareStatement(str);
			result=state.executeQuery();
			pillTable.setModel(new MyModel(result));
			
			pillTable.getColumnModel().getColumn(4).setMinWidth(0);
			pillTable.getColumnModel().getColumn(4).setMaxWidth(0);
			pillTable.getColumnModel().getColumn(4).setWidth(0);

			pillTable.getColumnModel().getColumn(4).setMinWidth(0);
			pillTable.getColumnModel().getColumn(4).setMaxWidth(0);
			pillTable.getColumnModel().getColumn(4).setWidth(0);

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
public void refreshCustomCombo() {
		
		customId=-1;

		comboCustomer.removeAllItems();
		
		String sql="select id, concat(fname,\' \',lname) from customer";
		//conn=DBConnection.getConnection();
		String item="";
		
		try {
			state=conn.prepareStatement(sql);
			result=state.executeQuery();
			if(result.next()) {
				customId=Integer.parseInt(result.getObject(1).toString());
				do {
					item=result.getObject(2).toString();
					comboCustomer.addItem(item);
				}while(result.next());
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
public void refreshFormCombo() {
	
	formId=-1;

	comboForm.removeAllItems();
	
	String sql="select id, name from form";
	//conn=DBConnection.getConnection();
	String item="";
	
	try {
		state=conn.prepareStatement(sql);
		result=state.executeQuery();
		if(result.next()) {
			formId=Integer.parseInt(result.getObject(1).toString());
			do {
				item=result.getObject(2).toString();
				comboForm.addItem(item);
			}while(result.next());
		}
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
}
public void refreshCategoryCombo() {
	
	catId=-1;

	comboCategory.removeAllItems();
	
	String sql="select id, name from category";
	//conn=DBConnection.getConnection();
	String item="";
	
	try {
		state=conn.prepareStatement(sql);
		result=state.executeQuery();
		if(result.next()) {
			catId=Integer.parseInt(result.getObject(1).toString());
			do {
				item=result.getObject(2).toString();
				comboCategory.addItem(item);
			}while(result.next());
		}
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
}
public void refreshDrugCombo() {
	
	medId=-1;
	unit_price=0;

	comboMedicament.removeAllItems();
	
	String sql="select id, name, price from drug";
	//conn=DBConnection.getConnection();
	String item="";
	
	try {
		state=conn.prepareStatement(sql);
		result=state.executeQuery();
		if(result.next()) {
			medId=Integer.parseInt(result.getObject(1).toString());
			unit_price=Double.parseDouble(result.getObject(3).toString());
			do {
				item=result.getObject(2).toString();
				comboMedicament.addItem(item);
			}while(result.next());
		}
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
}

public void refresh() {
	//order
	orderPanel.setLayout(new GridLayout(3,1));
	orderPanel.add(firstOrderPanel);
	orderPanel.add(secondOrderPanel);
	orderPanel.add(thirdOrderPanel);
	
	firstOrderPanel.setLayout(new GridLayout(4,2));
	firstOrderPanel.setBackground(Color.PINK);
	firstOrderPanel.add(customer);
	firstOrderPanel.add(comboCustomer);
	firstOrderPanel.add(medicament);
	firstOrderPanel.add(comboMedicament);
	firstOrderPanel.add(quantity);
	firstOrderPanel.add(setQuantity);
	firstOrderPanel.add(price);
	firstOrderPanel.add(setPrice);
	setPrice.addFocusListener(new FocusListener() {
		public void focusGained(FocusEvent e) {
	       setPrice.setText("");
	    }

	    public void focusLost(FocusEvent e) {
	    	if(setPrice.getText().equals("")) {
	    		setPrice.setText("*** Полето служи само за търсене на поръчки с цена над указаната");
	    }
	    }

	});
	//secondOrderPanel.setPreferredSize(new Dimension(20,20));
	secondOrderPanel.setLayout(new GridLayout(1,4));
	secondOrderPanel.setBackground(Color.PINK);
	secondOrderPanel.add(addOrderBtn);
	secondOrderPanel.add(editOrderBtn);
	secondOrderPanel.add(deleteOrderBtn);
	secondOrderPanel.add(searchOrderBtn);
	addOrderBtn.addActionListener(new AddOrderAction());
	editOrderBtn.addActionListener(new EditOrderAction());
	deleteOrderBtn.addActionListener(new DeleteOrderAction());
	searchOrderBtn.addActionListener(new SearchOrderAction());
	
	orderScroll.setPreferredSize(new Dimension(700, 150));
	thirdOrderPanel.add(orderScroll);
	thirdOrderPanel.setBackground(Color.PINK);
	orderTable.addMouseListener(new MouseActionOrderTable());
	
	//medicament
	pillPanel.setLayout(new GridLayout(3,1));
	pillPanel.add(firstPillPanel);
	pillPanel.add(secondPillPanel);
	pillPanel.add(thirdPillPanel);
	
	firstPillPanel.setLayout(new GridLayout(4,2));
	firstPillPanel.setBackground(Color.PINK);
	firstPillPanel.add(pillName);
	firstPillPanel.add(setPillName);
	firstPillPanel.add(pillCategory);
	firstPillPanel.add(comboCategory);
	firstPillPanel.add(pillForm);
	firstPillPanel.add(comboForm);
	firstPillPanel.add(pillPrice);
	firstPillPanel.add(setPillPrice);
	
	secondPillPanel.setLayout(new GridLayout(1,4));
	secondPillPanel.setBackground(Color.PINK);
	secondPillPanel.add(addPillBtn);
	secondPillPanel.add(editPillBtn);
	secondPillPanel.add(deletePillBtn);
	secondPillPanel.add(searchPillBtn);
	addPillBtn.addActionListener(new AddMedicamentAction());
	editPillBtn.addActionListener(new EditMedicamentAction());
	deletePillBtn.addActionListener(new DeleteMedicamentAction());
	searchPillBtn.addActionListener(new SearchMedicamentAction());
	
	pillScroll.setPreferredSize(new Dimension(700, 150));
	thirdPillPanel.add(pillScroll);
	thirdPillPanel.setBackground(Color.PINK);
	pillTable.addMouseListener(new MouseActionMedicamentTable());
	
	//category
	categoryPanel.setLayout(new GridLayout(3,1));
	categoryPanel.add(firstCategoryPanel);
	categoryPanel.add(secondCategoryPanel);
	categoryPanel.add(thirdCategoryPanel);
	
	firstCategoryPanel.setLayout(new GridLayout(1,2));
	firstCategoryPanel.setBackground(Color.PINK);
	firstCategoryPanel.add(categoryName);
	firstCategoryPanel.add(setCategoryName);
	
	secondCategoryPanel.setLayout(new GridLayout(1,4));
	secondCategoryPanel.setBackground(Color.PINK);
	secondCategoryPanel.add(addCategoryBtn);
	secondCategoryPanel.add(editCategoryBtn);
	secondCategoryPanel.add(deleteCategoryBtn);
	secondCategoryPanel.add(searchCategoryBtn);
	addCategoryBtn.addActionListener(new AddCategoryAction());
	editCategoryBtn.addActionListener(new EditCategoryAction());
	deleteCategoryBtn.addActionListener(new DeleteCategoryAction());
	searchCategoryBtn.addActionListener(new SearchCategoryAction());
	
	categoryScroll.setPreferredSize(new Dimension(700, 150));
	thirdCategoryPanel.add(categoryScroll);
	thirdCategoryPanel.setBackground(Color.PINK);
	categoryTable.addMouseListener(new MouseActionCategoryTable());
	
	//form
	formPanel.setLayout(new GridLayout(3,1));
	formPanel.add(firstFormPanel);
	formPanel.add(secondFormPanel);
	formPanel.add(thirdFormPanel);
	
	firstFormPanel.setLayout(new GridLayout(1,2));
	firstFormPanel.setBackground(Color.PINK);
	firstFormPanel.add(formName);
	firstFormPanel.add(setFormName);
	
	secondFormPanel.setLayout(new GridLayout(1,4));
	secondFormPanel.setBackground(Color.PINK);
	secondFormPanel.add(addFormBtn);
	secondFormPanel.add(editFormBtn);
	secondFormPanel.add(deleteFormBtn);
	secondFormPanel.add(searchFormBtn);
	addFormBtn.addActionListener(new AddFormAction());
	editFormBtn.addActionListener(new EditFormAction());
	deleteFormBtn.addActionListener(new DeleteFormAction());
	searchFormBtn.addActionListener(new SearchFormAction());
	
	formScroll.setPreferredSize(new Dimension(700, 150));
	thirdFormPanel.add(formScroll);
	thirdFormPanel.setBackground(Color.PINK);
	formTable.addMouseListener(new MouseActionFormTable());
	
	//customer
	customerPanel.setLayout(new GridLayout(3,1));
	customerPanel.add(firstCustomPanel);
	customerPanel.add(secondCustomPanel);
	customerPanel.add(thirdCustomPanel);
	
	firstCustomPanel.setLayout(new GridLayout(4,2));
	firstCustomPanel.setBackground(Color.PINK);
	firstCustomPanel.add(firstCustomName);
	firstCustomPanel.add(setFirstCustomName);
	firstCustomPanel.add(lastCustomName);
	firstCustomPanel.add(setLastCustomName);
	firstCustomPanel.add(customEmail);
	firstCustomPanel.add(setCustomEmail);
	firstCustomPanel.add(customPhone);
	firstCustomPanel.add(setCustomPhone);
	
	secondCustomPanel.setLayout(new GridLayout(1,4));
	secondCustomPanel.setBackground(Color.PINK);
	secondCustomPanel.add(addCustomBtn);
	secondCustomPanel.add(editCustomBtn);
	secondCustomPanel.add(deleteCustomBtn);
	secondCustomPanel.add(searchCustomBtn);
	addCustomBtn.addActionListener(new AddCustomerAction());
	editCustomBtn.addActionListener(new EditCustomerAction());
	deleteCustomBtn.addActionListener(new DeleteCustomerAction());
	searchCustomBtn.addActionListener(new SearchCustomerAction());
	
	customerScroll.setPreferredSize(new Dimension(700, 150));
	thirdCustomPanel.add(customerScroll);
	thirdCustomPanel.setBackground(Color.PINK);
	customerTable.addMouseListener(new MouseActionCustomerTable());
	
	//ref
	
	refPanel.setLayout(new GridLayout(4,1));
	refPanel.add(firstRefPanel);
	refPanel.add(news);
	refPanel.add(secondRefPanel);
	refPanel.add(thirdRefPanel);
	
	firstRefPanel.setLayout(new GridLayout(3,1));
	firstRefPanel.setBackground(Color.PINK);
	firstRefPanel.add(criterion);
	firstRefPanel.add(comboCriterion);
	firstRefPanel.add(submitBtn);
	
	submitBtn.addActionListener(new Search());
	
	news.setLayout(new GridLayout(3,2));
	secondRefPanel.setLayout(new GridLayout(1,1));
	secondRefPanel.add(searchRefBtn);
	secondRefPanel.setBackground(Color.PINK);
	
	searchRefBtn.addActionListener(new SearchDB());
	//searchRefBtn.setMinimumSize(new Dimension(20,40));
	refScroll.setPreferredSize(new Dimension(700, 150));
	thirdRefPanel.setBackground(Color.PINK);
	thirdRefPanel.add(refScroll);
	
	
	
			//actions
			comboCustomer.addActionListener(new ActionListener() {

				@Override
				public void actionPerformed(ActionEvent e) {
					// TODO Auto-generated method stub
					if((tab.getSelectedIndex()==0 || tab.getSelectedIndex()==5) && customId>0) {
						String name=comboCustomer.getSelectedItem().toString();
						String[] customArray = name.split(" ");
						//String str="select * from orders where customer_id="+first";
								String str="select * from customer where fname like '%"+customArray[0]+"%\' and lname like '%"+customArray[1]+"%'";
						try {
							state=conn.prepareStatement(str);
							result=state.executeQuery();
							result.next();
							customId=Integer.parseInt(result.getObject(1).toString());
						} catch (SQLException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
						}

						System.out.println(comboCustomer.getSelectedItem().toString());
						System.out.println(str);
						System.out.println(customId);
					}
				}
			
			});
			comboMedicament.addActionListener(new ActionListener() {

				@Override
				public void actionPerformed(ActionEvent e) {
					// TODO Auto-generated method stub
					if((tab.getSelectedIndex()==0 || tab.getSelectedIndex()==5) && medId>0) {
						String drugName=comboMedicament.getSelectedItem().toString();
						//String str="select * from orders where drug_id='"+comboMedicament.getSelectedItem().toString()+"'";
						String str="select id,price from drug where name like '%"+drugName+"%'";
						try {
							state=conn.prepareStatement(str);
							result=state.executeQuery();
							result.next();
							medId=Integer.parseInt(result.getObject(1).toString());
							unit_price=Double.parseDouble(result.getObject(2).toString());
						} catch (SQLException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
						}

						System.out.println(comboMedicament.getSelectedItem().toString());
						System.out.println(str);
						System.out.println(medId);
						System.out.println(unit_price);
					}else {
						System.out.println("null");
					}
				}
			
			});
			comboForm.addActionListener(new ActionListener() {

				@Override
				public void actionPerformed(ActionEvent e) {
					// TODO Auto-generated method stub
					if((tab.getSelectedIndex()==1 || tab.getSelectedIndex()==5) && formId>0) {
						String formName=comboForm.getSelectedItem().toString();
						//String str="select * from orders where drug_id='"+comboMedicament.getSelectedItem().toString()+"'";
						String str="select * from form where name like '%"+formName+"%'";
						try {
							state=conn.prepareStatement(str);
							result=state.executeQuery();
							result.next();
							formId=Integer.parseInt(result.getObject(1).toString());
						} catch (SQLException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
						}

						System.out.println(comboForm.getSelectedItem().toString());
						System.out.println(str);
						System.out.println(formId);
					}else {
						System.out.println("null");
					}
				}
			
			});
			comboCategory.addActionListener(new ActionListener() {

				@Override
				public void actionPerformed(ActionEvent e) {
					// TODO Auto-generated method stub
					if((tab.getSelectedIndex()==1 || tab.getSelectedIndex()==5) && catId>0) {
						String categoryName=comboCategory.getSelectedItem().toString();
						//String str="select * from orders where drug_id='"+comboMedicament.getSelectedItem().toString()+"'";
						String str="select * from category where name like '%"+categoryName+"%'";
						try {
							state=conn.prepareStatement(str);
							result=state.executeQuery();
							result.next();
							catId=Integer.parseInt(result.getObject(1).toString());
						} catch (SQLException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
						}

						System.out.println(comboCategory.getSelectedItem().toString());
						System.out.println(str);
						System.out.println(catId);
					}
					else {
						System.out.println("null");
					}
				}
			
			});
		

	
	
}

//Add button
class AddFormAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			
			conn=DbContext.getConnection();
			String sql="INSERT INTO FORM (name) VALUES(?)";
			
			try {
				state=conn.prepareStatement(sql);
				state.setString(1, setFormName.getText());
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			
			setFormName.setText("");
			refreshFormTable();
			refreshFormCombo();
		}
		
	}
	class AddCategoryAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			
			conn=DbContext.getConnection();
			String sql="INSERT INTO Category (name) VALUES(?)";
			
			try {
				state=conn.prepareStatement(sql);
				state.setString(1, setCategoryName.getText());
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			setCategoryName.setText("");
			refreshCategoryTable();
			refreshCategoryCombo();
		}
	}
	class AddCustomerAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			
			conn=DbContext.getConnection();
			String sql="INSERT INTO customer (fname, lname, phone,email) VALUES(?,?,?,?)";
			
			try {
				state=conn.prepareStatement(sql);
				state.setString(1, setFirstCustomName.getText());
				state.setString(2, setLastCustomName.getText());
				state.setString(3, setCustomPhone.getText());
				state.setString(4, setCustomEmail.getText());
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			setFirstCustomName.setText("");
			setLastCustomName.setText("");
			setCustomPhone.setText("");
			setCustomEmail.setText("");
			refreshCustomerTable();
			refreshCustomCombo();
			
		}
	}
	class AddMedicamentAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			
			conn=DbContext.getConnection();
			String sql="INSERT INTO drug (name, price, category_id,form_id) VALUES(?,?,?,?)";
			
			try {
				state=conn.prepareStatement(sql);
				state.setString(1, setPillName.getText());
				state.setFloat(2, Float.parseFloat(setPillPrice.getText()));
				state.setInt(3, catId);
				state.setInt(4, formId);
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			setPillName.setText("");
			setPillPrice.setText("");
			//catId=-1;
			//formId=-1;
			refreshDrugTable();
			refreshDrugCombo();
			refreshDrugTable();
			//refreshFormCombo();
			//refreshCategoryCombo();
		}
	}
	class AddOrderAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			
			conn=DbContext.getConnection();
			String sql="INSERT INTO orders (customer_id, drug_id, quantity,total_price) VALUES(?,?,?,?)";
			try {
				state=conn.prepareStatement(sql);
				state.setInt(1, customId);
				state.setInt(2, medId);
				state.setInt(3, Integer.parseInt(setQuantity.getText()));
				double total_price=unit_price*Integer.parseInt(setQuantity.getText());
				state.setDouble(4, total_price);
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			setQuantity.setText("");
			refreshOrderTable();
			//refreshCustomCombo();
			//refreshDrugCombo();
			//unit_price=0;
			//medId=-1;
			//customId=-1;
			refreshOrderTable();
			
		}
	}

	//edit button
	class EditFormAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			conn=DbContext.getConnection();
			String sql="UPDATE FORM set name=? where id=?";
			if(formId>0) {
			try {
				state=conn.prepareStatement(sql);
				state.setString(1, setFormName.getText());
				state.setInt(2, formId);
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			}
			setFormName.setText("");
			refreshFormTable();
			refreshFormCombo();
			formId=-1;
		}
	}
	class EditCategoryAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			conn=DbContext.getConnection();
			String sql="UPDATE category set name=? where id=?";
			if(catId>0) {
			try {
				state=conn.prepareStatement(sql);
				state.setString(1, setCategoryName.getText());
				state.setInt(2, catId);
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			}
			setCategoryName.setText("");
			refreshCategoryTable();
			refreshCategoryCombo();
			catId=-1;
		}
	}

	class EditCustomerAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			conn=DbContext.getConnection();
			String sql="UPDATE customer set fname=?, lname=?, phone=?, email=? where id=?";
			if(customId>0) {
				System.out.println("yes");
			try {
				state=conn.prepareStatement(sql);
				state.setString(1, setFirstCustomName.getText());
				state.setString(2, setLastCustomName.getText());
				state.setString(3, setCustomPhone.getText());
				state.setString(4, setCustomEmail.getText());
				state.setInt(5, customId);
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			}else {
				System.err.println("null");
			}
			setFirstCustomName.setText("");
			setLastCustomName.setText("");
			setCustomPhone.setText("");
			setCustomEmail.setText("");
			refreshCustomerTable();
			refreshCustomCombo();
			refreshOrderTable();
			customId=-1;
		}
	}
	class EditMedicamentAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			conn=DbContext.getConnection();
			String sql="UPDATE drug set name=?, price=?, category_id=?,form_id=? where id=?";
			if(medId>0) {
			try {
				state=conn.prepareStatement(sql);
				state.setString(1, setPillName.getText());
				state.setFloat(2, Float.parseFloat(setPillPrice.getText()));
				state.setInt(3, catId);
				state.setInt(4, formId);
				state.setInt(5, medId);
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			}
			setPillName.setText("");
			setPillPrice.setText("");
			refreshDrugTable();
			refreshDrugCombo();
			refreshOrderTable();
			catId=-1;
			formId=-1;
			medId=-1;
		}
	}
	class EditOrderAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			conn=DbContext.getConnection();
			String sql="UPDATE orders set customer_id=?,drug_id=?,quantity=?,total_price=? where id=?";
			if(orderId>0) {
			try {
				state=conn.prepareStatement(sql);
				state.setInt(1, customId);
				state.setInt(2, medId);
				state.setInt(3, Integer.parseInt(setQuantity.getText()));
				double total_price=unit_price*Integer.parseInt(setQuantity.getText());
				state.setDouble(4, total_price);
				state.setInt(5,orderId);
				state.execute();
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			}
			}
			setQuantity.setText("");
			refreshOrderTable();
			unit_price=0;
			medId=-1;
			customId=-1;
		}
	}
	
	//delete btn
	class DeleteFormAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			if(formId>0) {
				String sql="delete from form where id=?";
				try {
					state=conn.prepareStatement(sql);
					state.setInt(1, formId);
					state.execute();
				
				} catch (SQLException e1) {
				// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			
				setFormName.setText("");
				refreshFormTable();
				refreshFormCombo();
				refreshDrugTable();
				refreshDrugCombo();
				refreshOrderTable();
				formId=-1;
			}else {
				System.err.println("Null index");
			}
		}
		
	}
	class DeleteCategoryAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			if(catId>0) {
				String sql="delete from category where id=?";
				try {
					state=conn.prepareStatement(sql);
					state.setInt(1, catId);
					state.execute();
				
				} catch (SQLException e1) {
				// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			
				setCategoryName.setText("");
				refreshCategoryTable();
				refreshCategoryCombo();

				refreshDrugTable();
				refreshDrugCombo();
				refreshOrderTable();
				catId=-1;
			}
		}
		
	}
	class DeleteCustomerAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			if(customId>0) {
				String sql="delete from customer where id=?";
				try {
					state=conn.prepareStatement(sql);
					state.setInt(1, customId);
					state.execute();
				
				} catch (SQLException e1) {
				// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			
				setFirstCustomName.setText("");
				setLastCustomName.setText("");
				setCustomPhone.setText("");
				setCustomEmail.setText("");
				refreshCustomerTable();
				refreshCustomCombo();
				refreshOrderTable();
				customId=-1;
			}
		}
		
	}
	class DeleteMedicamentAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			if(medId>0) {
				String sql="delete from drug where id=?";
				try {
					state=conn.prepareStatement(sql);
					state.setInt(1, medId);
					state.execute();
				
				} catch (SQLException e1) {
				// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			
				setPillName.setText("");
				setPillPrice.setText("");
				refreshDrugTable();
				refreshDrugCombo();
				refreshOrderTable();
				medId=-1;
			}
		}
		
	}
	class DeleteOrderAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			if(orderId>0) {
				String sql="delete from orders where id=?";
				try {
					state=conn.prepareStatement(sql);
					state.setInt(1, orderId);
					state.execute();
				
				} catch (SQLException e1) {
				// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			
				setQuantity.setText("");
				refreshOrderTable();
				orderId=-1;
			}
		}
		
	}

	//добавяне на инфо в полетата за избрания обект
	class MouseActionFormTable implements MouseListener{
		@Override
		public void mouseClicked(MouseEvent e) {
			int row=formTable.getSelectedRow();		
			setFormName.setText(formTable.getValueAt(row, 0).toString());
			String str="";
			String name=formTable.getValueAt(row,0).toString();
			str="select id from form where name= \'"+name+"\'";
			try {
				state=conn.prepareStatement(str);
				result=state.executeQuery();
				result.next();
				formId=Integer.parseInt(result.getObject(1).toString());
			} catch (SQLException exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			} catch (Exception exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			}
		
			
		}

		@Override
		public void mouseEntered(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseExited(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mousePressed(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseReleased(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}
		
	}
	class MouseActionCategoryTable implements MouseListener{
		@Override
		public void mouseClicked(MouseEvent e) {
			int row=categoryTable.getSelectedRow();		
			setCategoryName.setText(categoryTable.getValueAt(row, 0).toString());
			String str="";
			String name=categoryTable.getValueAt(row,0).toString();
			str="select id from category where name= \'"+name+"\'";
			try {
				state=conn.prepareStatement(str);
				result=state.executeQuery();
				result.next();
				catId=Integer.parseInt(result.getObject(1).toString());
			} catch (SQLException exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			} catch (Exception exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			}
		
			
		}

		@Override
		public void mouseEntered(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseExited(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mousePressed(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseReleased(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}
		
	}
	class MouseActionCustomerTable implements MouseListener{
		@Override
		public void mouseClicked(MouseEvent e) {
			int row=customerTable.getSelectedRow();	
			String fname=customerTable.getValueAt(row,0).toString();
			String lname=customerTable.getValueAt(row,1).toString();
			setFirstCustomName.setText(customerTable.getValueAt(row, 0).toString());
			setLastCustomName.setText(customerTable.getValueAt(row, 1).toString());
			setCustomPhone.setText(customerTable.getValueAt(row, 2).toString());
			setCustomEmail.setText(customerTable.getValueAt(row, 3).toString());
			String str="";

			
			str="select id from customer where fname like '%"+fname+"%' and lname like '%"+lname+"%'";
			try {
				state=conn.prepareStatement(str);
				result=state.executeQuery();
				result.next();
				customId=Integer.parseInt(result.getObject(1).toString());
			} catch (SQLException exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			} catch (Exception exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			}
		
			
		}

		@Override
		public void mouseEntered(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseExited(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mousePressed(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseReleased(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}
		
	}
	class MouseActionMedicamentTable implements MouseListener{
		@Override
		public void mouseClicked(MouseEvent e) {
			int row=pillTable.getSelectedRow();		
			setPillName.setText(pillTable.getValueAt(row, 0).toString());
			setPillPrice.setText(pillTable.getValueAt(row, 1).toString());
			 String form=pillTable.getValueAt(row, 3).toString();
			String category=pillTable.getValueAt(row,2).toString();
			String s1="select id from form where name =\'"+form+"\'";
			try {
				state=conn.prepareStatement(s1);
				result=state.executeQuery();
				result.next();
				formId=Integer.parseInt(result.getObject(1).toString());
			} catch (SQLException exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			} catch (Exception exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			}
			String s2="select id from category where name= \'"+category+"\'";
			try {
				state=conn.prepareStatement(s2);
				result=state.executeQuery();
				result.next();
				catId=Integer.parseInt(result.getObject(1).toString());
			} catch (SQLException exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			} catch (Exception exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			}
			comboForm.setSelectedItem(form);
			comboCategory.setSelectedItem(category);
			String str="";
			String name=pillTable.getValueAt(row,0).toString();
			String price=pillTable.getValueAt(row,1).toString();
			String str1="select id from drug where name= \'"+name+"\' and price= "+price+"";
			try {
				state=conn.prepareStatement(str1);
				result=state.executeQuery();
				result.next();
				medId=Integer.parseInt(result.getObject(1).toString());
			} catch (SQLException exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			} catch (Exception exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			}
		
			
		}

		@Override
		public void mouseEntered(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseExited(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mousePressed(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseReleased(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}
		
	}
	class MouseActionOrderTable implements MouseListener{
		@Override
		public void mouseClicked(MouseEvent e) {
			int row=orderTable.getSelectedRow();		
			setQuantity.setText(orderTable.getValueAt(row, 2).toString());
			int quantity=(int) orderTable.getValueAt(row, 2);
			 String customer=orderTable.getValueAt(row, 0).toString();
				String[] customArray = customer.split(" ");
				String medicament=orderTable.getValueAt(row,1).toString();
				String s1="select id from customer where fname like '%"+customArray[0]+"%\' and lname like '%"+customArray[1]+"%\'";
				
				try {
					state=conn.prepareStatement(s1);
					result=state.executeQuery();
					result.next();
					customId=Integer.parseInt(result.getObject(1).toString());
					System.out.println(formName);
				} catch (SQLException exc) {
					// TODO Auto-generated catch block
					exc.printStackTrace();
				} catch (Exception exc) {
					// TODO Auto-generated catch block
					exc.printStackTrace();
				}
				String s2="select id, price from drug where name like \'%"+medicament+"%\'";
				try {
					state=conn.prepareStatement(s2);
					result=state.executeQuery();
					result.next();
					medId=Integer.parseInt(result.getObject(1).toString());
					unit_price=Double.parseDouble(result.getObject(2).toString());
				} catch (SQLException exc) {
					// TODO Auto-generated catch block
					exc.printStackTrace();
				} catch (Exception exc) {
					// TODO Auto-generated catch block
					exc.printStackTrace();
				}
				comboCustomer.setSelectedItem(customer);
				comboMedicament.setSelectedItem(medicament);
			String str="";
			
			str="select id from orders where customer_id= "+customId+" and drug_id="+medId+" and quantity="+quantity;
			try {
				state=conn.prepareStatement(str);
				result=state.executeQuery();
				result.next();
				orderId=Integer.parseInt(result.getObject(1).toString());
			} catch (SQLException exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			} catch (Exception exc) {
				// TODO Auto-generated catch block
				exc.printStackTrace();
			}
		
			
		}

		@Override
		public void mouseEntered(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseExited(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mousePressed(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseReleased(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}
		
	}

	//класовете обслужват бутоните за търсене в ссамите справки
	class SearchFormAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			conn=DbContext.getConnection();
			String sql="SELECT name FROM FORM WHERE NAME LIKE \'%"+setFormName.getText()+"%\'";
			
			try {
				state=conn.prepareStatement(sql);
			//	state.setString(1, setFormName.getText());
				result=state.executeQuery();
				formTable.setModel(new MyModel(result));
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			} catch (Exception e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		
		}
		}

	class SearchCategoryAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			conn=DbContext.getConnection();
			String sql="SELECT name FROM Category WHERE NAME LIKE \'%"+setCategoryName.getText()+"%\'";
			
			try {
				state=conn.prepareStatement(sql);
			//	state.setString(1, setFormName.getText());
				result=state.executeQuery();
				categoryTable.setModel(new MyModel(result));
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			} catch (Exception e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		
		}
		}

	class SearchCustomerAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			//System.out.println("hi");
			
			conn=DbContext.getConnection();
			
			String sql="SELECT fname,lname, phone, email FROM Customer WHERE FNAME LIKE \'%"
			+setFirstCustomName.getText()+"%\' AND LNAME LIKE \'%"+setLastCustomName.getText()+
			"%\' ";
			
			try {
				state=conn.prepareStatement(sql);
				
				result=state.executeQuery();
				customerTable.setModel(new MyModel(result));
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			} catch (Exception e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		
		}
		}

	class SearchMedicamentAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			
			conn=DbContext.getConnection();
			String sql="SELECT drug.name, price, form.name AS FORM, category.name AS CATEGORY FROM DRUG,CATEGORY, FORM "
					+ "WHERE drug.category_id=category.id AND  drug.form_id=form.id AND DRUG.NAME LIKE \'%"
			+setPillName.getText()+"%\' ";
			
			try {
				state=conn.prepareStatement(sql);
				
				result=state.executeQuery();
				pillTable.setModel(new MyModel(result));
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			} catch (Exception e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		
		}
		}
	
	class SearchOrderAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			//System.out.println("hi");
			
			conn=DbContext.getConnection();
			//System.out.println(setPrice.getText()); -test data
			String sql="SELECT concat(customer.fname,\' \',customer.lname) as customer,"
					+ " drug.name as medicament_name, orders.quantity, total_price"
					+ " FROM orders,drug,customer"
					+ " WHERE orders.customer_id=customer.id and orders.drug_id=drug.id "
					+ "AND TOTAL_PRICE>= \'"+setPrice.getText()+"\'";
			try {
				state=conn.prepareStatement(sql);
				
				result=state.executeQuery();
				orderTable.setModel(new MyModel(result));
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			} catch (Exception e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		
		}
		}

	//използват се за въвеждане на данни за справките
	JLabel label=new JLabel();
	JTextField textField=new JTextField();
	
	//класовете обслужват бутоните, използвани в раздела за справки
	class Search implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			criteria=comboCriterion.getSelectedItem().toString();
			System.out.println(criteria);
			
			if(criteria.equals("Търсене на клиент по телефон")) {
				news.removeAll();
				label.setText("Телефон: ");
				news.add(label);
				news.add(textField);
				c=0;
				
			} else if(criteria.equals("Търсене на клиент по имейл")) {
				news.removeAll();
				label.setText("Имейл: ");
				news.add(label);
				news.add(textField);
				c=1;
			}
			else if(criteria=="Търсене на лекарство по форма") {
				news.removeAll();
				label.setText("Форма: ");
				news.add(label);
				news.add(comboForm);
				c=2;
				
			}
			else if(criteria=="Търсене на лекарство по предназначение (област)") {
				news.removeAll();
				label.setText("Предназначение: ");
				news.add(label);
				news.add(comboCategory);
				c=3;
			}
			else if(criteria=="Търсене на породукт по единична цена") {
				news.removeAll();
				label.setText("Цена: ");
				news.add(label);
				news.add(textField);
				c=4;
			}
			else if(criteria=="Търсене на лекарство по предназначение и форма") {
				news.removeAll();
				news.add(pillCategory);
				news.add(comboCategory);
				news.add(pillForm);
				news.add(comboForm);
				c=5;
			}else if(criteria=="Търсене на продукт по цена и категория") {
			news.removeAll();
				label.setText("Задайте цена: ");
				news.add(label);
				news.add(textField);
				news.add(pillCategory);
				news.add(comboCategory);
				c=6;
			}
			else if(criteria=="Търсене на поръчка по клиент") {
			news.removeAll();
				label.setText("Клиент: ");
				news.add(label);
				news.add(comboCustomer);
				c=7;
			}
			else if(criteria=="Търсене на поръчка по лекарство") {
				news.removeAll();
				label.setText("Лекарство: ");
				news.add(label);
				news.add(comboMedicament);
				c=8;
			}
			else if(criteria=="Търсене на поръчка по брой поръчани лекарства") {
				news.removeAll();
				label.setText("Брой на поръчваните лекарства: ");
				news.add(label);
				news.add(textField);
				c=9;
				
			}else if(criteria=="Търсене на поръчка по лекарство и брой поръчвани продукти") {
				news.removeAll();
				label.setText("Брой на поръчваните лекарсвта: ");
				news.add(label);
				news.add(textField);
				news.add(pillName);
				news.add(comboMedicament);
				c=10;
			}
			else if(criteria=="Търсене на поръчка по дефинирани клиент и лекарство") {
				news.removeAll();
				news.add(customer);
				news.add(comboCustomer);
				news.add(medicament);
				news.add(comboMedicament);
				c=11;
			}
		}
		
	}

	class SearchDB implements ActionListener{
		public void checkAction(){

		if(c==0) {
			sql="SELECT FNAME,LNAME, PHONE,EMAIL FROM CUSTOMER WHERE PHONE like \'%"+textField.getText()+"%\'";
			System.out.println(setCustomPhone.getText());
		
		}else if(c==1) {
			sql="SELECT FNAME,LNAME, PHONE,EMAIL FROM CUSTOMER WHERE EMAIL like \'%"+textField.getText()+"%\'";
		}else if(c==2) {
			sql="SELECT DRUG.NAME,PRICE, CATEGORY.NAME AS CATEGORY, FORM.NAME AS FORM FROM DRUG, FORM, CATEGORY WHERE "
					+ "FORM_ID=FORM.ID AND CATEGORY_ID=CATEGORY.ID AND "
					+ "FORM_ID="+formId;
			//firstPillPanel.add(comboCategory);	
			
		}else if(c==3) {
			sql="SELECT DRUG.NAME,PRICE, CATEGORY.NAME AS CATEGORY, FORM.NAME AS FORM FROM DRUG, FORM, CATEGORY WHERE "
					+ "FORM_ID=FORM.ID AND CATEGORY_ID=CATEGORY.ID AND "
					+ "CATEGORY_ID="+catId;
			//firstPillPanel.add(comboCategory);	
		}else if(c==4) {
			sql="SELECT DRUG.NAME,PRICE, CATEGORY.NAME AS CATEGORY, FORM.NAME AS FORM FROM DRUG, FORM, CATEGORY WHERE "
					+ "FORM_ID=FORM.ID AND CATEGORY_ID=CATEGORY.ID AND "
					+ "PRICE="+textField.getText();
		}
		else if(c==5) {
			sql="SELECT DRUG.NAME,PRICE, CATEGORY.NAME AS CATEGORY, FORM.NAME AS FORM FROM DRUG, FORM, CATEGORY WHERE "
					+ "FORM_ID=FORM.ID AND CATEGORY_ID=CATEGORY.ID AND "
					+ "FORM_ID="+formId+" AND CATEGORY_ID="+catId;
			//firstPillPanel.add(pillForm);
			//firstPillPanel.add(comboForm);	
			//firstPillPanel.add(pillCategory);	
			//firstPillPanel.add(comboCategory);	
		}
		else if(c==6) {
			sql="SELECT DRUG.NAME,PRICE, CATEGORY.NAME AS CATEGORY, FORM.NAME AS FORM FROM DRUG, FORM, CATEGORY WHERE "
					+ "FORM_ID=FORM.ID AND CATEGORY_ID=CATEGORY.ID AND "
					+ "PRICE="+textField.getText()+" AND CATEGORY_ID="+catId;
			//firstPillPanel.add(pillCategory);
			//firstPillPanel.add(comboCategory);	
		}else if(c==7) {
			sql="SELECT CONCAT (FNAME,\' \',LNAME) AS CUSTOMER,DRUG.NAME, QUANTITY, TOTAL_PRICE"
					+ " FROM DRUG, CUSTOMER, ORDERS WHERE "
					+ "CUSTOMER_ID=CUSTOMER.ID AND DRUG_ID=DRUG.ID AND "
					+ "CUSTOMER_ID="+customId;
			//firstOrderPanel.add(comboCustomer);	
		}else if(c==8) {
			sql="SELECT CONCAT (FNAME,\' \',LNAME) AS CUSTOMER,DRUG.NAME, QUANTITY, TOTAL_PRICE"
					+ " FROM DRUG, CUSTOMER, ORDERS WHERE "
					+ "CUSTOMER_ID=CUSTOMER.ID AND DRUG_ID=DRUG.ID AND "
					+ "DRUG_ID="+medId;
			//firstOrderPanel.add(comboMedicament);	
		}else if(c==9) {
			sql="SELECT CONCAT (FNAME,\' \',LNAME) AS CUSTOMER,DRUG.NAME, QUANTITY, TOTAL_PRICE"
					+ " FROM DRUG, CUSTOMER, ORDERS WHERE "
					+ "CUSTOMER_ID=CUSTOMER.ID AND DRUG_ID=DRUG.ID AND "
					+ "QUANTITY="+textField.getText();
		}else if(c==10) {
			sql="SELECT CONCAT (FNAME,\' \',LNAME) AS CUSTOMER,DRUG.NAME, QUANTITY, TOTAL_PRICE"
					+ " FROM DRUG, CUSTOMER, ORDERS WHERE "
					+ "CUSTOMER_ID=CUSTOMER.ID AND DRUG_ID=DRUG.ID AND "
					+ "QUANTITY="+textField.getText()+" AND DRUG_ID="+medId;
			//firstOrderPanel.add(pillName);	
			//firstOrderPanel.add(comboMedicament);	
		}else if(c==11) {
			sql="SELECT CONCAT (FNAME,\' \',LNAME) AS CUSTOMER,DRUG.NAME, QUANTITY, TOTAL_PRICE"
					+ " FROM DRUG, CUSTOMER, ORDERS WHERE "
					+ "CUSTOMER_ID=CUSTOMER.ID AND DRUG_ID=DRUG.ID AND "
					+ "CUSTOMER_ID="+customId+" AND DRUG_ID="+medId;
			//firstOrderPanel.add(customer);
			//firstOrderPanel.add(comboCustomer);
			//firstOrderPanel.add(medicament);
			//firstOrderPanel.add(comboMedicament);		
			}
		}
		
		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			checkAction();
			conn=DbContext.getConnection();
			try {
				state=conn.prepareStatement(sql);
				result=state.executeQuery();
				refTable.setModel(new MyModel(result));
				
			} catch (SQLException e1) {
				//System.err.println("Err in prepare statement");
				e1.printStackTrace();
			} catch (Exception e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
			refresh();
		}
	
	}

		
}
	



