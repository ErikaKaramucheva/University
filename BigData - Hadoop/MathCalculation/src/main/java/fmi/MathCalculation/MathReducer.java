package fmi.MathCalculation;

import java.io.IOException;
import java.util.Iterator;

import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reducer;
import org.apache.hadoop.mapred.Reporter;

public class MathReducer extends MapReduceBase implements Reducer<IntWritable,LongWritable,IntWritable,LongWritable> {

	@Override
	public void reduce(IntWritable key, Iterator<LongWritable> values,
			OutputCollector<IntWritable, LongWritable> output, 
			Reporter reporter) throws IOException {
		output.collect(key, values.next());
		// TODO Auto-generated method stub
		
	}

}
