package fmi.CourseWork18;

import java.awt.Color;
import java.awt.Component;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.TextArea;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URI;
import java.net.URISyntaxException;

import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JSplitPane;
import javax.swing.JTextField;

import org.apache.hadoop.conf.Configuration;
import org.apache.hadoop.fs.FileSystem;
import org.apache.hadoop.fs.Path;
import org.apache.hadoop.io.DoubleWritable;
import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.FileInputFormat;
import org.apache.hadoop.mapred.FileOutputFormat;
import org.apache.hadoop.mapred.JobClient;
import org.apache.hadoop.mapred.JobConf;

public class Frame extends JFrame {
	JPanel mainPanel = new JPanel(null);

	JLabel manufacturerLabel = new JLabel("Please, enter a province code: ");
	JLabel categoryLabel = new JLabel("Please, enter a category type: ");
	JLabel milkLabel = new JLabel("Please, enter a milk type: ");
	JLabel chooseLabel = new JLabel("Please, choose calculation type: ");

	JTextField manufacturerTF = new JTextField();
	JTextField categoryTF = new JTextField();
	JTextField milkTF = new JTextField();

	JRadioButton firstCalculationBtn = new JRadioButton(
			"Average MoisturePercent value for selected cheese category and milk type.");
	JRadioButton secondCalculationBtn = new JRadioButton(
			"Percentage of organic cheeses in the direction of all cheeses by category and province.");

	ButtonGroup radioButtons = new ButtonGroup();

	TextArea result = new TextArea();
	JButton search = new JButton("Search");

	public Frame() {
		this.setSize(1000, 800);
		this.setVisible(true);
		this.setTitle("Cheese Data Processing and Analysis");
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		manufacturerLabel.setBounds(150, 30, 300, 50);
		manufacturerLabel.setFont(new Font("Serif", Font.BOLD, 18));
		manufacturerTF.setBounds(500, 30, 300, 50);
		categoryLabel.setBounds(150, 110, 300, 50);
		categoryLabel.setFont(new Font("Serif", Font.BOLD, 18));
		categoryTF.setBounds(500, 110, 300, 50);
		milkLabel.setBounds(150, 190, 300, 50);
		milkLabel.setFont(new Font("Serif", Font.BOLD, 18));
		milkTF.setBounds(500, 190, 300, 50);
		chooseLabel.setBounds(50, 295, 250, 50);
		chooseLabel.setFont(new Font("Serif", Font.BOLD, 18));
		firstCalculationBtn.setBounds(310, 270, 650, 50);
		firstCalculationBtn.setFont(new Font("Serif", Font.PLAIN, 18));
		secondCalculationBtn.setBounds(310, 320, 650, 50);
		secondCalculationBtn.setFont(new Font("Serif", Font.PLAIN, 18));
		search.setBounds(350, 380, 250, 50);
		search.setFont(new Font("Serif", Font.BOLD, 18));
		result.setBounds(100, 440, 800, 280);
		result.setFont(new Font("Serif", Font.PLAIN, 18));

		firstCalculationBtn.setActionCommand("1");
		secondCalculationBtn.setActionCommand("2");
		firstCalculationBtn.setSelected(true);

		radioButtons.add(firstCalculationBtn);
		radioButtons.add(secondCalculationBtn);

		mainPanel.add(manufacturerLabel);
		mainPanel.add(manufacturerTF);
		mainPanel.add(categoryLabel);
		mainPanel.add(categoryTF);
		mainPanel.add(milkLabel);
		mainPanel.add(milkTF);
		mainPanel.add(chooseLabel);
		mainPanel.add(firstCalculationBtn);
		mainPanel.add(secondCalculationBtn);
		mainPanel.add(search);
		mainPanel.add(result);
		mainPanel.setBackground(Color.orange);

		search.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				String cheeseCategory = categoryTF.getText();
				String milkType = milkTF.getText();
				String province = manufacturerTF.getText();
				if (radioButtons.getSelection().getActionCommand().equals("1")) {
					startHadoopWithFirstOption(cheeseCategory, milkType);
				} else {
					startHadoopWithSecondOption(cheeseCategory, province);
				}
			}
		});

		this.add(mainPanel);
	}

	private void startHadoopWithSecondOption(String cheeseCategory, String province) {
		Configuration config = new Configuration();
		Path inputPath = new Path("hdfs://127.0.0.1:9000/input/18.csv");
		Path outputPath = new Path("hdfs://127.0.0.1:9000/result");
		JobConf job = new JobConf(config);
		job.set("cheeseCategory", cheeseCategory);
		job.set("province", province);
		job.setMapperClass(PercentMapper.class);
		job.setReducerClass(PercentReducer.class);
		job.setOutputKeyClass(Text.class);
		job.setOutputValueClass(DoubleWritable.class);
		FileInputFormat.setInputPaths(job, inputPath);
		FileOutputFormat.setOutputPath(job, outputPath);
		try {
			FileSystem fs = FileSystem.get(new URI("hdfs://127.0.0.1:9000"), config);
			if (fs.exists(outputPath)) {
				fs.delete(outputPath, true);
				System.out.println("Изходната директория беше изтрита.");
			}
			JobClient.runJob(job);
			result.setText("");
			Path resultPath = new Path("hdfs://127.0.0.1:9000/result/part-00000");
			InputStreamReader reader = new InputStreamReader(fs.open(resultPath));
			BufferedReader line = new BufferedReader(reader);
			String lineText;
			while ((lineText = line.readLine()) != null) {
				result.append(lineText + "\n");
			}
			line.close();
			reader.close();
		} catch (IOException | URISyntaxException e) {
			e.printStackTrace();
		}
	}

	private void startHadoopWithFirstOption(String cheeseCategory, String milkType) {
		Configuration config = new Configuration();
		Path inputPath = new Path("hdfs://127.0.0.1:9000/input/18.csv");
		Path outputPath = new Path("hdfs://127.0.0.1:9000/result");
		JobConf job = new JobConf(config);
		job.set("cheeseCategory", cheeseCategory);
		job.set("milkType", milkType);
		job.setMapperClass(AverageValueMapper.class);
		job.setReducerClass(AverageValueReducer.class);
		job.setOutputKeyClass(Text.class);
		job.setOutputValueClass(DoubleWritable.class);
		FileInputFormat.setInputPaths(job, inputPath);
		FileOutputFormat.setOutputPath(job, outputPath);
		try {
			FileSystem fs = FileSystem.get(new URI("hdfs://127.0.0.1:9000"), config);
			if (fs.exists(outputPath)) {
				fs.delete(outputPath, true);
				System.out.println("Изходната директория беше изтрита.");
			}
			JobClient.runJob(job);
			result.setText("");
			Path resultPath = new Path("hdfs://127.0.0.1:9000/result/part-00000");
			InputStreamReader reader = new InputStreamReader(fs.open(resultPath));
			BufferedReader line = new BufferedReader(reader);
			String lineText;
			while ((lineText = line.readLine()) != null) {
				result.append(lineText + "\n");
			}
			line.close();
			reader.close();
		} catch (IOException | URISyntaxException e) {
			e.printStackTrace();
		}

	}

}
