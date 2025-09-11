let rad = parseFloat(prompt("Enter the radius of the circle: "));
let area = Math.PI * rad * rad;
alert("The area of the circle is: " + area.toFixed(2));

let anotherValue = parseFloat(
  prompt("Enter another value to calculate its sqrt: ")
);
alert(
  "The square root of " +
    anotherValue +
    " is: " +
    Math.sqrt(anotherValue).toFixed(2)
);

let calcCos = parseFloat(
  prompt("Enter the angle in degrees to calculate its cos: ")
);
let radians = (calcCos * Math.PI) / 180;
console.log(
  "The cosine of " + calcCos + " degrees is: " + Math.cos(radians).toFixed(2)
);
