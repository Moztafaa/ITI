/*
    Prevent creating any object from shape and create static Property
    that counts numbers of created objects in shape
    allow creation of only one square and one rectangle.
   */
export default class Shape {
  constructor() {
    if (this.constructor === Shape) {
      throw new Error("Cannot create an instance of Shape");
    }
    Shape.incrementCount();
  }

  static incrementCount() {
    if (!this.count) {
      this.count = 0;
    }
    this.count++;
  }

  static getCount() {
    return this.count || 0;
  }

  getArea() {
    return 0;
  }

  getPerimeter() {
    return 0;
  }

  // Display the area and each object parameter in your console by overriding toString().
  toString() {
    return `Area: ${this.getArea()}, Perimeter: ${this.getPerimeter()}`;
  }
}
