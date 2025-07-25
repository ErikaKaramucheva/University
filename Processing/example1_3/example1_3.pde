import processing.svg.*;

import processing.svg.*;

void setup(){
  size (600,600);
  //background(0);
    translate(mouseX,mouseY);
   circle(320, 240,500);
 }

 void draw(){
  // circle(mouseX, mouseY, 50);
  // strokeWeight(random(11));
   //stroke(random(255));
   //point(random(width),random(height));
   //circle(random(5), random(7),50);
    
   translate(300,300);
   strokeWeight(random(10));
   stroke(random(255),random(255),random(255));
   float randomWidth=random(width);
   float randomHeight= random(height);
   point(randomWidth, randomHeight);
   //point(mouseY-mouseX,mouseX-mouseY);
   point(width-randomWidth, height-randomHeight);
   point(-randomWidth,-randomHeight);
   point(-randomHeight,-randomWidth);
  
   
   }
   
   
 
