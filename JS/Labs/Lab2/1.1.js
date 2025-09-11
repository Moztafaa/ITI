let searchIn = prompt("Enter the message: ");
let letterToSearch = prompt(
  "Enter a single character to count in the message: "
);

function takeSingleChar() {
  letterToSearch = prompt("Enter a single character to count in the message: ");
}

while (letterToSearch.length > 1) {
  alert("Please enter a single character!!");
  takeSingleChar();
}

let AskForCase = confir("Do you want to make it case sensitive?");

let flags = AskForCase ? "g" : "gi";
let regex = new RegExp(letterToSearch, flags);

let count = (searchIn.match(regex) || []).length;

alert(
  "The letter " +
    letterToSearch +
    " appears " +
    count +
    " times in your message."
);
