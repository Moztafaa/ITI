let r1 = parseInt(prompt("Enter the start of the range:"));
let r2 = parseInt(prompt("Enter the end of the range:"));
let by3 = [];
let by5 = [];
function calcMultiplesOf3And5(r1, r2) {
  let sum = 0;
  for (let i = r1; i <= r2; i++) {
    if (i % 3 == 0) {
      by3.push(i);
      sum += i;
    }
    if (i % 5 == 0) {
      by5.push(i);
      sum += i;
    }
  }
  let by3String = by3.join(",");
  let by5String = by5.join(",");
  console.log(`Number multiple of 3: ${by3String}`);
  console.log(`Number multiple of 5: ${by5String}`);
  console.log(`total sum is ${sum}`);
  return sum;
}

let result = calcMultiplesOf3And5(r1, r2);
