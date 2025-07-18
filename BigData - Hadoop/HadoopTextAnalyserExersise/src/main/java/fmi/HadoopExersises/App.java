package fmi.HadoopExersises;

import java.io.IOException;
import java.net.URI;
import java.net.URISyntaxException;

import org.apache.hadoop.conf.Configuration;
import org.apache.hadoop.fs.FileSystem;
import org.apache.hadoop.fs.Path;
import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.LongWritable;
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
        Path inputPath=new Path("hdfs://127.0.0.1:9000/input/data.txt");
        Path outputPath=new Path("hdfs://127.0.0.1:9000/result");
        JobConf job=new JobConf(config);
        job.setMapperClass(MyMapper.class);
        job.setReducerClass(MyReducer.class);
        job.setOutputKeyClass(Text.class);
        job.setOutputValueClass(IntWritable.class);
        job.setInputFormat(TextInputFormat.class);
        job.setOutputFormat(TextOutputFormat.class);
        FileInputFormat.setInputPaths(job,inputPath);
        FileOutputFormat.setOutputPath(job,outputPath);
        try {
        	 FileSystem fs = FileSystem.get(new URI("hdfs://127.0.0.1:9000/result"), config);
             if (fs.exists(outputPath)) {
                 fs.delete(outputPath, true); 
                 System.out.println("Изходната директория беше изтрита.");
             }
			JobClient.runJob(job);
			System.out.println("Successfully");
		} catch (IOException | URISyntaxException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
    }
}
