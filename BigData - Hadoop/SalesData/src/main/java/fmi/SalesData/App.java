package fmi.SalesData;

import java.awt.Panel;
import java.awt.TextArea;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URI;
import java.net.URISyntaxException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JTextField;

import org.apache.hadoop.conf.Configuration;
import org.apache.hadoop.fs.FileSystem;
import org.apache.hadoop.fs.Path;
import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.FileInputFormat;
import org.apache.hadoop.mapred.FileOutputFormat;
import org.apache.hadoop.mapred.JobClient;
import org.apache.hadoop.mapred.JobConf;

/**
 * Hello world!
 */
public class App extends JFrame {
    public static void main(String[] args) {
    	new App();
    }
    
    private TextArea result;
    private JTextField input;
    
    public App() {
    	run();
    }
    
    public void run(){
    	Panel panel=new Panel();
    	
    	JTextField input= new JTextField();
    	JButton search =new JButton("Search");
    	result=new TextArea();
    	
    	
    	panel.add(input);
    	panel.add(search);
    	panel.add(result);

    	panel.setLayout(null);
    	panel.setSize(640,800);
    	input.setBounds(100,100,440,30);
    	search.setBounds(220,160,160,30);
    	result.setBounds(100,220,440,480);
    	
    	search.addActionListener(new ActionListener(){

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			startHadoop(input.getText());
		
		}
    	});
    	//hadoop startHadoop
    	
    	this.add(panel);
    	this.setVisible(true);
    	this.setSize(640,800);
    	this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

	public void startHadoop(String city) {
		Configuration config = new Configuration();
		// path to file "hdfs:localhost:9000"
		Path inputPath = new Path("hdfs://127.0.0.1:9000/input/SalesJan2009.csv");
		Path outputPath = new Path("hdfs://127.0.0.1:9000/result");
		JobConf job = new JobConf(config);
		job.set("cityFilter", city);
		job.setMapperClass(SalesMapper.class);
		job.setReducerClass(SalesReducer.class);
		job.setOutputKeyClass(Text.class);
		job.setOutputValueClass(IntWritable.class);
		FileInputFormat.setInputPaths(job, inputPath);
		FileOutputFormat.setOutputPath(job, outputPath);
		try {
			FileSystem fs = FileSystem.get(new URI("hdfs://127.0.0.1:9000"), config);
			if (fs.exists(outputPath)) {
				fs.delete(outputPath, true);
				System.out.println("Изходната директория беше изтрита.");
			}
			JobClient.runJob(job);
			// if task is successful - write
			result.setText("");
			Path resultPath = new Path("hdfs://127.0.0.1:9000/result/part-00000");
			InputStreamReader reader = new InputStreamReader(fs.open(resultPath));
			BufferedReader line = new BufferedReader(reader);
			String lineText;
			while ((lineText = line.readLine()) != null) {
				result.append(lineText + "\n");
			}
			reader.close();
			// System.out.println("Successfully");
		} catch (IOException | URISyntaxException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
