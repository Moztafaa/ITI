let toPali = prompt("Enter string to check Palindrome or not: ");

let AskForCase = confirm("Do you want to make it case sensitive?");

if (!AskForCase) {
  toPali = toPali.toLowerCase();
}

let reverse = toPali.split("").reverse().join("");

toPali == reverse ? alert("Valide 🟢") : alert("Not Valide 🔴");
