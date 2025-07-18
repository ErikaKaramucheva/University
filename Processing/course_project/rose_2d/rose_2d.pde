//https://en.wikipedia.org/wiki/Rose_(mathematics)

void setup() {
  size(900, 900);
  //background(255);
  background(0);
  fill(random(255), random(255), random(255));
  //stroke(255);
  //strokeWeight(2);
  frameRate(120);
}

float theta = 0;
float r = 0;
int s=int(random(50, 100));
int h=int(random(4, 6));
float t=random(0.2, 0.3);


void draw() {

  if (theta < 366) {
    translate(width/2, height/2);
    r = s * tan(h*theta);
    float x = r * cos(theta*(PI/180));
    float y = r * sin(theta*(PI/180));

    circle(x, y, 4);
    theta += t; // .2/.3 for filling
    println(x + ", " + y + "\t\t" + theta);
  }
}



void mouseClicked() {
  saveFrame("grid_2d_######.png");
}
