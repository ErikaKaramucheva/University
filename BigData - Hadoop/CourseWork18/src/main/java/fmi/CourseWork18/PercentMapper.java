package fmi.CourseWork18;

import java.io.IOException;

import org.apache.hadoop.io.DoubleWritable;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.JobConf;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.Mapper;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reporter;

public class PercentMapper extends MapReduceBase implements Mapper<LongWritable, Text, Text, DoubleWritable> {
	String cheeseCategory;
	String province;

	@Override
	public void configure(JobConf job) {
		cheeseCategory = job.get("cheeseCategory", "").trim().toLowerCase();
		province = job.get("province", "").trim().toLowerCase();
	}

	@Override
	public void map(LongWritable key, Text value, OutputCollector<Text, DoubleWritable> output, Reporter reporter)
			throws IOException {
		if (key.get() == 0) {
			return;
		}

		String[] columns = value.toString().split(",(?=(?:[^\\\"]*\\\"[^\\\"]*\\\")*[^\\\"]*$)");
		if (columns.length < 12) {
			return;
		}

		// province-1, category- 7,organic- 6
		if ((columns[1].toLowerCase().contains(province)) && (columns[7].toLowerCase().contains(cheeseCategory))) {
			Text keyOutput = new Text(
					columns[1].replace("\"", "").trim() + "  -  " + columns[7].replace("\"", "").trim());
			if (columns[6].contains("1")) {
				output.collect(keyOutput, new DoubleWritable(1));
			} else {
				output.collect(keyOutput, new DoubleWritable(0));
			}
		}
	}
}
