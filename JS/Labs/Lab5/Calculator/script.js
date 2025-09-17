let inputField = document.getElementById('Answer');

function EnterNumber(num) {
  inputField.value += num;
}

function EnterOperator(op) {
  inputField.value += op;
}

function EnterClear() {
  inputField.value = '';
}

function EnterEqual() {
  let expression = inputField.value;
  let stack = [];
  let num = '';
  let operators = {
    '+': (a, b) => a + b,
    '-': (a, b) => a - b,
    '*': (a, b) => a * b,
    '/': (a, b) => a / b,
  };
  let i = 0;
  if (expression[0] === '-') {
    num = '-';
    i = 1;
  }

  for (; i < expression.length; i++) {
    let char = expression[i];
    if (!isNaN(char) || char === '.') {
      num += char;
    } else if (operators[char]) {
      if (num) {
        stack.push(parseFloat(num));
      }
      num = '';
      stack.push(char);
    }
  }
  if (num) {
    stack.push(parseFloat(num));
  }
  while (stack.length >= 3) {
    let b = stack.pop();
    let operator = stack.pop();
    let a = stack.pop();
    stack.push(operators[operator](a, b));
  }
  inputField.value = stack[0];

}
