package fmi.SalesExercise;

import java.io.IOException;

import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.Mapper;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reporter;

public class SalesMapper extends MapReduceBase implements Mapper<LongWritable,Text,Text,IntWritable>{

	@Override
	public void map(LongWritable key, Text value, OutputCollector<Text, IntWritable> output, Reporter reporter)
			throws IOException {
		if(key.get()==0) {
			return;
		}
		String line=value.toString();
		String[] columns=line.split(",");
		
		Text targetColumnValue = new Text(columns[3]);
		output.collect(targetColumnValue, new IntWritable(1));
		
		
	}

}
