import Shape from "./Shape.js";
import Rectangle from "./Rectangle.js";
import Circle from "./circle.js";
import Square from "./Square.js";

let shapes = [
  new Rectangle(10, 20),
  new Circle(10),
  new Circle(5),
  new Square(10),
];

shapes.forEach((shape) => {
  console.log(shape.toString());
});
