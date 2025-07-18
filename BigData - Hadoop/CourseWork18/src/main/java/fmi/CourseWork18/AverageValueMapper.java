package fmi.CourseWork18;

import java.io.IOException;
import java.text.DecimalFormat;

import org.apache.hadoop.io.DoubleWritable;
import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapred.JobConf;
import org.apache.hadoop.mapred.MapReduceBase;
import org.apache.hadoop.mapred.Mapper;
import org.apache.hadoop.mapred.OutputCollector;
import org.apache.hadoop.mapred.Reporter;

public class AverageValueMapper extends MapReduceBase implements Mapper<LongWritable, Text, Text, DoubleWritable> {
	String cheeseCategory;
	String milkType;

	@Override
	public void configure(JobConf job) {
		cheeseCategory = job.get("cheeseCategory", "").trim().toLowerCase();
		milkType = job.get("milkType", "").trim().toLowerCase();
	}

	@Override
	public void map(LongWritable key, Text value, OutputCollector<Text, DoubleWritable> output, Reporter reporter)
			throws IOException {
		if (key.get() == 0) {
			return;
		}

		String[] columns = value.toString().split(",(?=(?:[^\\\"]*\\\"[^\\\"]*\\\")*[^\\\"]*$)");
//		if (columns.length < 12) {
//			return;
//		}
		// category type- 7, milk type- 8, mp- 3
		String category = columns[7].trim().toLowerCase();
		String type = columns[8].trim().toLowerCase();

		if ((category.contains(cheeseCategory) && type.contains(milkType))) {
			Text keyOutput = new Text(category.replace("\"", "") + "  -  " + type.replace("\"", ""));
			String percent = columns[3].replace("\"", "").trim();
			if (!percent.isEmpty()) {
				double currentPercent = Double.parseDouble(percent);
				output.collect(keyOutput, new DoubleWritable(currentPercent));
			}
		}

	}

}
