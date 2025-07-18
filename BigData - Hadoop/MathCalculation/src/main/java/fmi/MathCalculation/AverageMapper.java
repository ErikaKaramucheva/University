package fmi.MathCalculation;

import java.io.IOException;

import org.apache.hadoop.io.DoubleWritable;
import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.Mapper;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reporter;

public class AverageMapper extends MapReduceBase implements Mapper<LongWritable,Text,LongWritable, DoubleWritable>{

	@Override
	public void map(LongWritable key, Text value, OutputCollector<LongWritable, DoubleWritable> output,
			Reporter reporter) throws IOException {
		String[] values=value.toString().split(" ");
		double numbersCount=values.length;
		double sum=0;
		for(int i=0;i<values.length;i++) {
			int current= Integer.parseInt(values[i]);
			sum+=current;
		}
		double avg=sum/numbersCount;
		output.collect(key, new DoubleWritable(avg));
	}

}
