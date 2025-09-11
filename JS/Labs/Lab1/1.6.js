let inputNum = parseInt(prompt("Enter a positive integer:"));
for (let i = 1; i <= inputNum; i++) {
  let row = "";
  for (let j = 0; j < i; j++) {
    row += "*";
  }
  console.log(row);
}
