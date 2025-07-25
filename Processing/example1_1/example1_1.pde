void setup(){ //извиква се само веднъж
size(520,410); //screen size
background(0); //color 


//circle
//center 320,240
//max 640,480
circle(320,240,220); //for drawing
 stroke(255,0,0);// щрих
strokeWeight(7); //колко дебел е този щрих
  
//rectangle
rect(120,80, 220, 220);
rectMode(CENTER);
}

void draw(){ //извиква се всеки път
background(255);
circle(20,40,20); 
 stroke(0,255,0);
strokeWeight(7); 

circle(mouseX,mouseY,20); //ползва координатите на мишката
 stroke(255,0,0);
strokeWeight(3); 
}
