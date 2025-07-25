Walker first;
ArrayList<Walker> walkers = new ArrayList();

void setup() {
  size(640, 640);
  background(0);
  frameRate(120);

  first = new Walker();

  for (int i = 0; i < 33; i++) {
    walkers.add(new Walker());
  }
}

void draw() {
  first.drawWalker();

  for (Walker w : walkers) {
    w.drawWalker();
  }
}



class Walker {
  // properties
  int x, y;
  float r, step;
  color c;

  // constructor
  Walker() {
    // Prepare walker
    x = width/2;
    y = height/2;
    c = color(random(255), random(255), random(255));
    step = random(3, 10);
  }

  // methods
  void drawWalker() {
    // Prepare walker
    strokeWeight(step);
    stroke(c);
    r = random(8);

    // Choose direction
    if (r < 2) {
      x += step;
    } else if (r < 4) {
      x -= step;
    } else if (r < 6) {
      y += step;
    } else if (r < 8) {
      y -= step;
    }

    // bring back to screen
    if (x > width || x < 0) {
      x = width/2;
      c = color(random(255), random(255), random(255));
      step = random(3, 10);
    }
    if (y > height || y < 0) {
      y = height/2;
      c = color(random(255), random(255), random(255));
    }

    // draw walker
    for (int i=0; i<30; i++) {
      if (i%2==0 && i%5==0) {
        circle(x, y, 20);
      } else if (i%2==0) {
        rect(x, y, 15,15);
      } else if (i%5==0) {
        square(x, y, 25);
      } else {
        point(x, y);
      }
    }
  }
}
