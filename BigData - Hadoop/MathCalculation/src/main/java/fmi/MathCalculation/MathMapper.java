package fmi.MathCalculation;

import java.io.IOException;
import java.util.StringTokenizer;

import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.Mapper;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reporter;

public class MathMapper extends MapReduceBase implements Mapper<LongWritable,Text,IntWritable,LongWritable> {

	@Override
	public void map(LongWritable key, Text value, 
			OutputCollector<IntWritable, LongWritable> output, Reporter reporter)
			throws IOException {
		String[] numbers=value.toString().split(" ");
		Long largestNumber=Long.parseLong(numbers[0]);
		for(int i=0;i<numbers.length;i++) {
			Long currentNumber=Long.parseLong(numbers[i]);{
				if(currentNumber>largestNumber) {
					largestNumber=currentNumber;
				}
			}
		}
		output.collect(new IntWritable(Integer.parseInt(numbers[0])), new LongWritable(largestNumber));
		
		
	}

}
