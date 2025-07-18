/*PImage img;

void setup(){
  size(900,900,P3D);
  img=loadImage("img_flower.jpg");
  img.resize(900,900);
}
void draw(){
  background(255,255,255);
  fill(0);
  noStroke();
 
 float tiles=1000;
  float tileSize=width/tiles;
  
  push();
  translate(width/2,height/2);
  rotateY(radians(frameCount));
  for(int x=0;x<tiles;x+=5){
    for(int y=0;y<tiles;y+=5){
      color c=img.get(int(x*tileSize),int(y*tileSize));
     fill(0,0,236);
      float b=map(brightness(c),0,255,2,0);
      float z=map(b,0,1,-100,100);

      push();
translate(x*tileSize-width/2,y*tileSize-height/2,z);
     ellipse(0,0,tileSize*b*2,tileSize*b*2);
   pop();  
  }
  }
  pop();
}
void mouseClicked() {
  saveFrame("flower_3d_######.png");
}*/
