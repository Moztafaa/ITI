function dispVal(obj, key) {
  return obj[key] + (key === "age" ? " years old" : "");
}

const obj = {nm: "ali", age: 10};
const key = "age";
console.log(dispVal(obj, key));
