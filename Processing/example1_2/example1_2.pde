void setup() { //извиква се само веднъж
  size(800, 800); //screen size
  background(255); //color

for (int i = 0; i < 700; i = i+5) {
    line(random(width), 0, 65+random(height), height);
    if (i%2==0) {
      stroke(0, 156, 214);
    } else {
      stroke(105, 183, 155);
    }
}}
/*for( int i=0; i<steps;i++){
stroke(i/5,i/5,i/2);
line(random(width),0,50+random(height),height);

}
}
int steps=888;*/
  //line(x1,y1,x2,y2)
  //line(0,0,340,300);
  //stroke(233,188,195);
//  x1=50;
 // y2=0;
  //x2=width-50;
  //y2=max-height;

/*void draw() {
  //background(0);
  //random(x)- ot 0 do x
  for (int i = 0; i < 400; i = i++) {

    //line(i, 0, 400, i);
    line(i, 0, 400, i);
    if (i%5==0) {
      stroke(0, 255, 255);
    } else {
      stroke(255, 0, 255);
    }
  }
}*/
