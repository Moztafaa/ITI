/**
 * reference error
 * range error
 * syntax error
 * type error
 */

// console.log(x)
// console.log(1
// var x =1.235
// console.log(x.toFixed(120))

// var x = "str"
// console.log(x())
var err = new Error('msg')
// ReferenceError
// RangeError
// SyntaxError
// TypeError
var err1 = new ReferenceError('test reference error')
var err2 = new RangeError('test range error')
function fun(x,y){
    if(typeof x == 'number' && typeof y == 'number'&& !Number.isNaN(x)&&!Number.isNaN(y))
        return x + y
    // throw 'wrong data type'
    // throw err
    throw err2
}

// // fun()

// var num1 = prompt('Enter your first number',0)
// var num2 = prompt('Enter your second number',0)
// if(isFinite(num1)&& isFinite(num2)){
//     num1 = parseInt(num1)
//     num2 = parseInt(num2)
//     console.log(fun(num1,num2))

// }
// else{
//     alert('Enter valid data')
// }




// try{
//     var x = 1
//     var y = x + z
//     console.log(y)
// }
// catch(err){
//     // console.log(err)
// }
// console.log('test')

try{
    num1 = parseInt(prompt('Enter your first number',0))
    num2 = parseInt(prompt('Enter your second number',0))
    alert(fun(num1,num2))
}
catch(err){
    if(err instanceof RangeError){
        console.log('range error')
    }else if(err instanceof ReferenceError){
        console.log('reference error')
    }
    else{
        console.log(err)
    }
    // throw 'error'
}finally{
    console.log('finally')
}
console.log('last line')













