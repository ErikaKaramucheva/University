package adapter;

public class AdapterClient {

	public static void main(String[] args) {
		ExternalDataProvider extDtProv=new ExternalSource();
		DataProvider provider=new DataAdapter(extDtProv);
		provider.getData("test.png");
	}

}
