package command;

public class RemoteController {
	private Command command;

	public void setCommand(Command command) {
		this.command = command;
	}
	
	public void pressDoButton() {
		if(this.command==null) {
			System.out.println("No command to execute!");
			return;
		}
		this.command.execute();
	}
	public void pressUndoButton() {
		if(this.command==null) {
			System.out.println("No command to execute!");
			return;
		}
		this.command.undo();
	}

}
