package fmi.CourseWork18;

import java.io.IOException;
import java.util.Iterator;

import org.apache.hadoop.io.DoubleWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reducer;
import org.apache.hadoop.mapred.Reporter;

public class AverageValueReducer extends MapReduceBase implements Reducer<Text, DoubleWritable, Text, DoubleWritable> {

	@Override
	public void reduce(Text key, Iterator<DoubleWritable> values, OutputCollector<Text, DoubleWritable> output,
			Reporter reporter) throws IOException {
		int count = 0;
		double sum = 0;
		while (values.hasNext()) {
			count += 1;
			sum += values.next().get();
		}

		DoubleWritable avg = new DoubleWritable(0);
		if (count > 0) {
			avg = new DoubleWritable(sum / (double) count);
		}
		if(avg.get() != 0.0) {
			output.collect(key, avg);
		}

	}

}
