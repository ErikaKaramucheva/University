package uni.fmi.bachelors;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class MainForm extends JFrame {

	private JPanel p2ATTF;
	private JTextField P1NameTF;
	private JTextField p1HPTF;
	private JTextField p1PowerTF;
	private JTextField p1EVADETF;
	private JTextField p1ATTF;
	private JTextField P2NameTF;
	private JTextField p2HPTF;
	private JTextField p2PowerTF;
	private JTextField textField;
	private JTextField p2EVADETF;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MainForm frame = new MainForm();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public MainForm() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 347);
		p2ATTF = new JPanel();
		p2ATTF.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(p2ATTF);
		p2ATTF.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("Name");
		lblNewLabel.setBounds(26, 37, 49, 14);
		p2ATTF.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("HP");
		lblNewLabel_1.setBounds(26, 73, 49, 14);
		p2ATTF.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Power:");
		lblNewLabel_2.setBounds(26, 114, 49, 14);
		p2ATTF.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Attack Speed");
		lblNewLabel_3.setBounds(26, 139, 87, 14);
		p2ATTF.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Evade");
		lblNewLabel_4.setBounds(26, 176, 49, 14);
		p2ATTF.add(lblNewLabel_4);
		
		P1NameTF = new JTextField();
		P1NameTF.setBounds(85, 34, 96, 20);
		p2ATTF.add(P1NameTF);
		P1NameTF.setColumns(10);
		
		p1HPTF = new JTextField();
		p1HPTF.setBounds(85, 70, 96, 20);
		p2ATTF.add(p1HPTF);
		p1HPTF.setColumns(10);
		
		p1PowerTF = new JTextField();
		p1PowerTF.setBounds(85, 111, 96, 20);
		p2ATTF.add(p1PowerTF);
		p1PowerTF.setColumns(10);
		
		p1EVADETF = new JTextField();
		p1EVADETF.setBounds(85, 173, 96, 20);
		p2ATTF.add(p1EVADETF);
		p1EVADETF.setColumns(10);
		
		p1ATTF = new JTextField();
		p1ATTF.setBounds(117, 136, 96, 20);
		p2ATTF.add(p1ATTF);
		p1ATTF.setColumns(10);
		
		JLabel lblNewLabel_5 = new JLabel("Name");
		lblNewLabel_5.setBounds(262, 37, 49, 14);
		p2ATTF.add(lblNewLabel_5);
		
		JLabel lblNewLabel_1_1 = new JLabel("HP");
		lblNewLabel_1_1.setBounds(250, 73, 49, 14);
		p2ATTF.add(lblNewLabel_1_1);
		
		JLabel lblNewLabel_3_1 = new JLabel("Attack Speed");
		lblNewLabel_3_1.setBounds(223, 139, 87, 14);
		p2ATTF.add(lblNewLabel_3_1);
		
		JButton FightButton = new JButton("Fight");
		FightButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String firstPokemonName=P1NameTF.getText();
				int firstPokemonPower=Integer.parseInt(p1PowerTF.getText());
				int firstPokemonHp=Integer.parseInt(p1HPTF.getText());
				int firstPokemonEvadeChance=Integer.parseInt(p1EVADETF.getText());
				int firstPokemonAttackSpeed=Integer.parseInt(p1ATTF.getText());
				
				String secondPokemonName=P2NameTF.getText();
				int secondPokemonPower=Integer.parseInt(p2PowerTF.getText());
				int secondPokemonHp=Integer.parseInt(p2HPTF.getText());
				int secondPokemonEvadeChance=Integer.parseInt(p2EVADETF.getText());
				int secondPokemonAttackSpeed=Integer.parseInt(textField.getText());
				
				Pokemon p1=new Pokemon(firstPokemonName, firstPokemonPower, firstPokemonHp, firstPokemonEvadeChance, firstPokemonAttackSpeed);
				Pokemon p2=new Pokemon(secondPokemonName, secondPokemonPower, secondPokemonHp, secondPokemonEvadeChance, secondPokemonAttackSpeed);
				
				
				p1.target=p2;
				p2.target=p1;
				
				p1.start();
				p2.start();
				
				}
		});
		FightButton.setEnabled(false);
		FightButton.setBounds(188, 235, 89, 23);
		p2ATTF.add(FightButton);
		
		JLabel lblNewLabel_2_1 = new JLabel("Power:");
		lblNewLabel_2_1.setBounds(228, 114, 49, 14);
		p2ATTF.add(lblNewLabel_2_1);
		
		JLabel lblNewLabel_4_1 = new JLabel("Evade");
		lblNewLabel_4_1.setBounds(239, 176, 49, 14);
		p2ATTF.add(lblNewLabel_4_1);
		
		P2NameTF = new JTextField();
		P2NameTF.setColumns(10);
		P2NameTF.setBounds(306, 34, 96, 20);
		p2ATTF.add(P2NameTF);
		
		p2HPTF = new JTextField();
		p2HPTF.setColumns(10);
		p2HPTF.setBounds(306, 70, 96, 20);
		p2ATTF.add(p2HPTF);
		
		p2PowerTF = new JTextField();
		p2PowerTF.setColumns(10);
		p2PowerTF.setBounds(306, 111, 96, 20);
		p2ATTF.add(p2PowerTF);
		
		textField = new JTextField();
		textField.setBounds(306, 136, 96, 20);
		p2ATTF.add(textField);
		textField.setColumns(10);
		
		p2EVADETF = new JTextField();
		p2EVADETF.setColumns(10);
		p2EVADETF.setBounds(306, 173, 96, 20);
		p2ATTF.add(p2EVADETF);
	}
}
