// 1
let a = 100, b = 200;
[a, b] = [b, a];
console.log(a, b);
// -----------------------------------------------
// 2
let arr = [100, 200, 300, 400, 500];
function returnMinMax(...numbers) {
    let min = Math.min(...numbers);
    let max = Math.max(...numbers);
    return { min, max };
}
let { min, max } = returnMinMax(...arr);
console.log(`Min: ${min}, Max: ${max}`);
// -----------------------------------------------
// 3 - a.
let fruits = ["apple", "strawberry", "banana", "orange", "mango"];
let testString = fruits.every((f) => typeof f === "string");
console.log(testString);
// -----------------------------------------------
// 3 - b.
let startWithA = fruits.map((f) => f.startsWith("a"));
let startWithASome = fruits.some((f) => f.startsWith("a"));
console.log(startWithA);
console.log(startWithASome);
// -----------------------------------------------
// 3 - c.
let startWithBorS = fruits.filter((f) =>
    f.toLowerCase().startsWith("b") || f.toLowerCase().startsWith("s")
);
console.log(startWithBorS);
// -----------------------------------------------
// 3 - d.
let likeFruits = fruits.map((f) => `I like ${f}`);
console.log(likeFruits);
// -----------------------------------------------
// 3 - e.
let displayFruits = fruits.forEach((f) => console.log(f));
