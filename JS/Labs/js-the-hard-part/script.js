// function outer() {
//     let counter = 0;
//     function incrementCounter() {
//         counter++;
//         console.log(counter);
//     }
//     return incrementCounter;
// }
// const myNewfunction = outer();
// myNewfunction();
// const mofunction = myNewfunction;
// mofunction();
// myNewfunction(); // C.O.V.E ... closed over variable enviroment (Backpack)
//
//
function once(fn) {
    let hasBeenCalled = false;
    let result;
    return function (...args) {
        if (!hasBeenCalled) {
            hasBeenCalled = true;
            result = fn(...args);
            return result;
        }
        return result;
    };
}
function logInitialSetup(user) {
    console.log(`Setting Up initial configuration for ${user}`);
    return `Setup complete for ${user}`;
}
const runSetupOnce = once(logInitialSetup);
console.log(runSetupOnce("Alice"));
console.log(runSetupOnce("John"));
console.log(runSetupOnce("Bob"));
// -----------
function once1(fn) {
    let called = false;
    return function (...args) {
        if (called) return;
        called = true;
        return fn.apply(this, args);
    };
}
// Example usage:
const greetOnce = once1(function (name) {
    console.log(`Hello, ${name}`);
});
greetOnce("Alice"); // Output: Hello, Alice
greetOnce("Bob"); // No output, function will not run again
greetOnce("Bob"); // No output, function will not run again
