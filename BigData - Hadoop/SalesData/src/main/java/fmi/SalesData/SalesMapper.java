package fmi.SalesData;

import java.io.IOException;

import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.JobConf;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.Mapper;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reporter;

public class SalesMapper extends MapReduceBase implements Mapper<LongWritable,Text,Text,IntWritable>{
	String cityFilter; 

	@Override
	public void configure(JobConf job) {
		cityFilter = job.get("cityFilter", "");// default if it is null
	}

	@Override
	public void map(LongWritable key, Text value, OutputCollector<Text, IntWritable> output, Reporter reporter)
			throws IOException {
		String[] columns=value.toString().split(",");
		//1- product, 5-grad - start from 0
		if((columns[5].toLowerCase()).contains(cityFilter.toLowerCase())) {
			Text keyOutput=new Text(columns[5]+ "-"+columns[1]);
			output.collect(keyOutput, new IntWritable(1));
		}
		
	}

}
