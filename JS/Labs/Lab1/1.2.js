let sum = 0;
while (sum <= 100) {
  let num = parseFloat(prompt("Enter a number:"));
  if (num == 0) break;
  if (!isNaN(num)) sum += num;
  console.log(`Sum is: ${sum}`);
}
