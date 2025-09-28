import Shape from "./Shape.js";

export default class Circle extends Shape {
  constructor(radius) {
    super();
    this.radius = radius;
  }

  getArea() {
    return Math.PI * this.radius * this.radius;
  }
  getPerimeter() {
    return 2 * Math.PI * this.radius;
  }
  toString() {
    return `Circle - Radius: ${this.radius}, ${super.toString()}`;
  }
}
