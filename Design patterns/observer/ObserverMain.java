package observer;

public class ObserverMain {

	public static void main(String[] args) {
		
		Topic topic=new Topic();
		Observer obs1=new TopicSubscriber("Иван");
		Observer obs2=new TopicSubscriber("Петър");
		Observer obs3=new TopicSubscriber("Мария");
		topic.subscribe(obs1);
		topic.subscribe(obs2);
		topic.subscribe(obs3);
		topic.setTopic("Subscribe");
		topic.unsubscribe(obs3);
		topic.setTopic("Unsubscribe ");
	}

}
