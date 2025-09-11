// ask a user to enter a message
let message = prompt("Please enter a message:");

// display the message in header
document.write(`<h1>${message}</h1>`);

for (let i = 1; i <= 6; i++) {
  document.write(`<h${i}>${message}</h${i}>`);
}
