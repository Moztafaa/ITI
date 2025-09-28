import Shape from "./Shape.js";
export default class Square extends Shape {
  static #instance = null;
  constructor(sideLength) {
    super();
    this.sideLength = sideLength;
    if (Square.#instance) {
      throw new Error("Cannot create more than one instance of Square");
    }
    Square.#instance = this;
  }

  getArea() {
    return this.sideLength * this.sideLength;
  }

  getPerimeter() {
    return 4 * this.sideLength;
  }

  toString() {
    return `Square - Side Length: ${this.sideLength}, ${super.toString()}`;
  }
}
