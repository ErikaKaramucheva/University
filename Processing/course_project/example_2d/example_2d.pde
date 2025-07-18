/*int grid=int(random(20,100)); 
int margin=5;


void setup() {
  size(800, 800);
  noLoop();
}

void draw() {
  background(255);
  noFill();

  float d=grid*0.8;
  for (int i=margin; i<=width-margin; i+=grid) {
    for (int j=margin; j<height-margin; j+=grid) {
      stroke(random(255), random(255), random(255));
      strokeWeight(2);

      for(int num=0;num<7;num++){
       float x1=-random(d);
       float y1=-random(d);
       float x2=random(d);
       float y2=-random(d);
       float x3=random(d);
       float y3=random(d);
       float x4=-random(d);
       float y4=random(d);
      


      pushMatrix();
      translate (i, j);
      quad(x1, y1, x2, y2, x3, y3,x4,y4);
      popMatrix();
      }
    }
  }
}


void keyPressed() {
  if (key=='-') redraw();
}

void mouseClicked() {
  saveFrame("lines_2d_######.png");
}*/
