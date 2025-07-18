package fmi.MathCalculation;

import java.io.IOException;
import java.util.Iterator;

import org.apache.hadoop.io.DoubleWritable;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reducer;
import org.apache.hadoop.mapred.Reporter;

public class AverageReducer extends MapReduceBase implements Reducer<LongWritable,DoubleWritable,LongWritable,DoubleWritable> {

	@Override
	public void reduce(LongWritable key, Iterator<DoubleWritable> values,
			OutputCollector<LongWritable, DoubleWritable> output, Reporter reporter) throws IOException {
		output.collect(key, values.next());
		
	}

}
