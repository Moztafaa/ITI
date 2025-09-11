let str = "We will, we will rock you";

console.log(str.match(/we/gi)); // We,we (an array of 2 substrings that match)
console.log(str.match(/we/i)); // give first match of form of array (match, index, input)
// console.log(str.matchAll(/we/));
let matches = "JavaScript".match(/HTML/); // = null
let matchesHandleNull = "JavaScript".match(/HTML/) || [];

// no flag g
console.log("We will, we will".replace(/we/i, "I")); // I will, we will

// with flag g
console.log("We will, we will".replace(/we/gi, "I")); // I will, I will

let strr = "I love JavaScript";
let regexp = /LOVE/i;

console.log(regexp.test(strr)); // true

// $& insert at the end
// $` insert before the match
// without flags => regexp == string search
