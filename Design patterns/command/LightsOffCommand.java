package command;

public class LightsOffCommand implements Command {
	private Lights lights;

	@Override
	public void execute() {
		this.lights.switchOff();

	}

	public LightsOffCommand(Lights lights) {
		super();
		this.lights = lights;
	}

	@Override
	public void undo() {
		this.lights.switchOn();

	}

}
