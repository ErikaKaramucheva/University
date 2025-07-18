int grid=400;
float angle;
int aX=40;
int aY=135;
float scaleVar=1;



void setup() {
  size(960, 1080, P3D);
  surface.setLocation(957, 0);
 // rectMode(CENTER);
  //fill(255, 0, 0);
  noStroke();
  aX=(width-floor(width/(grid+2))*(grid+2))/2;
 aY=(height-floor(width/(grid+2))*(grid+2))/2; //square output
 
}

void draw() {
  background(15, 20, 30);
  
  translate(width/2,height/2);
  scaleVar=lerp(scaleVar,map(mouseX,0,width,0.1,5),0.1);
  scale(scaleVar);
  for (int x=aX+grid-width/2; x<=width/2-aX; x+=grid*2) {
   for (int y=aY+grid-height/2; y<=height/2-aY; y+=grid*2) {
     //if(x%2==0||y%2==0){
       //fill(123,54,87);
     //}else{
         //fill(235,63,134);}
      pushMatrix();
      translate(x, y);

      //top left
      pushMatrix();
      translate(-grid/2, -grid/2);
      rotateX(radians(angle));
      rotateY(-radians(angle));
      fill(random(255),random(255),random(255));
      stroke(1);
      box(grid);
      //rect(0, 0, grid, grid);
      popMatrix();

      //top right
      pushMatrix();
      translate(-grid/2, +grid/2);
      rotateX(-radians(angle));
      rotateY(radians(angle));
      fill(random(255),random(255),random(255));
      box(grid);
     //rect(0, 0, grid, grid);
      popMatrix();

      //bottom left
      pushMatrix();
      translate(+grid/2, -grid/2);
      rotateX(-radians(angle));
      rotateY(-radians(angle));
      fill(random(255),random(255),random(255));
      box(grid);
     // rect(0, 0, grid, grid);
      popMatrix();

      //bottom right
      pushMatrix();
      translate(+grid/2, +grid/2);
      rotateX(-radians(angle));
      rotateY(-radians(angle));
      fill(random(255),random(255),random(255));
      box(grid);
      //rect(0, 0, grid, grid);
      popMatrix();

      popMatrix();
    }
  }
  angle+=1;
  if (angle>=180) {
    grid/=2;
    if (grid<=5) {
      grid=400;
    }
    angle=0;
  }
}

void mouseClicked() {
  saveFrame("shape_3d_######.png");
}
