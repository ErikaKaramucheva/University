package fmi.TextAnalyzer;

import java.io.IOException;
import java.net.URI;
import java.net.URISyntaxException;

import org.apache.hadoop.conf.Configuration;
import org.apache.hadoop.fs.FileSystem;
import org.apache.hadoop.fs.Path;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.FileInputFormat;
import org.apache.hadoop.mapred.FileOutputFormat;
import org.apache.hadoop.mapred.JobClient;
import org.apache.hadoop.mapred.JobConf;
import org.apache.hadoop.mapred.TextInputFormat;
import org.apache.hadoop.mapred.TextOutputFormat;

/**
 * Hello world!
 */
public class App {
    public static void main(String[] args) {
        Configuration config=new Configuration();
        //path to file "hdfs:localhost:9000"
        Path inputPath=new Path("hdfs://localhost:9000/data.txt");
        Path outputPath=new Path("hdfs://localhost:9000/r");
        JobConf job=new JobConf(config);
        job.setMapperClass(MyMapper.class);
        job.setReducerClass(MyReducer.class);
        job.setOutputKeyClass(Text.class);
        job.setOutputValueClass(Text.class);
        job.setInputFormat(TextInputFormat.class);
        job.setOutputFormat(TextOutputFormat.class);
        FileInputFormat.setInputPaths(job,inputPath);
        FileOutputFormat.setOutputPath(job,outputPath);
        try {
        	 FileSystem fs = FileSystem.get(new URI("hdfs://localhost:9000"), config);
             if (fs.exists(outputPath)) {
                 fs.delete(outputPath, true); // Изтрий съществуващата директория
                 System.out.println("Изходната директория беше изтрита.");
             }
			JobClient.runJob(job);
			System.out.println("Successfully");
		} catch (IOException | URISyntaxException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
        
        
        /*try {
        	FileSystem fileSystem=FileSystem.get(URI.create("hdfs:\\path to "),job);
        if(fileSystem) {
        	//проверка дали има информация и ако я има, затрива
        	//start
        	JobClient.runJob(job);
        	//проверка дали всичко е минало успешно
        	System.out.println("Successfully");
        }
        }catch {
        	
        }*/
        
        
        
    }
}
