// Fill an array (n numerical values) from the user, the n is determined by the user.
// Use sort method to sort the array’s values in descending and ascending orders
// Display the output in the console.

let n = parseInt(prompt("Enter the number of values you want to input: "));
while (isNaN(n) || n <= 0) {
  alert("Please enter a valid positive integer!");
  n = parseInt(prompt("Enter the number of values you want to input: "));
}

let values = [];
for (let i = 0; i < n; i++) {
  let value = parseFloat(prompt(`Enter value ${i + 1}: `));
  while (isNaN(value)) {
    alert("Please enter a valid number!");
    value = parseFloat(prompt(`Enter value ${i + 1}: `));
  }
  values.push(value);
}
// don't use spread operator
console.log("Original values: ", values);
let ascending = values.sort((a, b) => a - b);
console.log("Values in ascending order: ", ascending);
let descending = values.sort((a, b) => b - a);
console.log("Values in descending order: ", descending);

