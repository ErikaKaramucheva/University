void setup(){
  size(600,600);
  background(255);
  translate(width/2,height/2);
  ellipse(224,184,200,20);
   circle(320,240,50);
  }
  
  void draw(){
    strokeWeight(random(5));
    stroke(random(255),random(255),random(255));
   //rotate(radians(r*7));
    int x=1;
    for(int i=11;i>2;i--){
      ellipse(i*10,0,200,20-x);
      ellipse(-x,0,200,20-x);
      ellipse(-x,0,200,20-x);
      ellipse(x,0,200,20-x);
      x*=10;
      }
     
      
    }
