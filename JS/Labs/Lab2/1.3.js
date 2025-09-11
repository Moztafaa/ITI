let str = prompt("Enter the string to find the longest word on it: ");

function ReturnMaxWord(str) {
  let arr = str.split(" ");
  let maxWord = arr[0];

  for (let i = 1; i < arr.length; i++) {
    maxWord = arr[i].length > maxWord.length ? arr[i] : maxWord;
  }
  return maxWord;
}

alert("The longest word is: " + ReturnMaxWord(str));
