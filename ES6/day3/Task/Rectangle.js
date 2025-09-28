import Shape from "./Shape.js";


export default class Rectangle extends Shape {
  static #instance = null;
  constructor(width, height) {
    super();
    this.width = width;
    this.height = height;
    if (Rectangle.#instance) {
      throw new Error("Cannot create more than one instance of Rectangle");
    }
    Rectangle.#instance = this;
  }
  getArea() {
    return this.width * this.height;
  }
  getPerimeter() {
    return 2 * (this.width + this.height);
  }

  toString() {
    return `Rectangle - Width: ${this.width}, Height: ${
      this.height
    }, ${super.toString()}`;
  }
}
