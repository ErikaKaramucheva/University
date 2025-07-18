package command;

public class Lights {
	private Boolean LightsOn;
	public void  switchOn() {
		System.out.println("Lights are on");
		this.LightsOn=true;
	}
	public void  switchOff() {
		System.out.println("Lights are off");
		this.LightsOn=false;
	}

}
