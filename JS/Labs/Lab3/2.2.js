function dispVal(obj, key) {
  return obj[key] + (key === "age" ? " years old" : "");
}

let obj = {nm: "ali", age: 10};
let key = "age";
console.log(dispVal(obj, key));
