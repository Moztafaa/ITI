
// console.log(myval)
console.log('...............................')
//Hoisting
console.log(x)//undefined
document.writeln('External File')


//loosly typed
var x = 1
console.log(x)
console.log(typeof x)

// x = true
// console.log(typeof x)
var y = "str"
console.log(typeof y)
console.log(y)
/**primitive dataTypes 
 * 
 * es5
 * number
 * string
 * boolean
 * null
 * undefined
 * 
 * es6
 * symbol
 * bigint
*/

var z = x + y
x = 1
y = true
z = x + y


var num
console.log(num)
console.log(typeof num)

var first_name="ahmed"

// console.log(pi)

// console.log(i)//undefined
for(let i=0;i<3;i++){
    console.log(i)//0-1-2
}
// console.log(i)//3

const pi = 1 
// pi = 1.2


let val = "data"
 val = "xyz"
/**
 * global scope
 * script scope
 * block scope
 * function scope
 */

var myName = "Arwa"
myName[0] = 'x'
console.log(myName[0])
myName = "Nour"


x = 1
// y = ++x
// console.log(y)
// console.log(x)

y =2
z = 3
// z<y=3<2---->false
// false<x--0<1
if(z>y<x){
    console.log('yes')
}
else{
    console.log('no')
}

y = "1"
if(x!==y){
    console.log('not equal')
}
else{
    console.log('equal')
}


xyzData = 1//global scope---window object

var temp = 100
// if(temp>50){
//     var color = 'red'
// }
// else{
//     color = 'green'
// }
var color = (temp>50)?'red':'green';

//functions ---->displaying dialog box
//alert
//propmpt
//confirm
// alert('hello')
// var num1 = prompt('Enter your first number',0)
/**prompt return null when press cancel
 * press ok--->return string value
 */

// var num2 = prompt('Enter your second number',0)
// if(isFinite(num1)&&isFinite(num2)){
//     num1 = parseInt(num1)
//     num2 = parseInt(num2)
//     var sum = num1+num2
//     console.log(sum)
// }
// else{
//     alert('re-enter your values')
// }
//Number.NaN-----Logical Error
//null,undefined----primitive datatypes
//undefined
//NaN---->Not a Number
// isFinite
// isNaN


/**
 * false values
 * empty string
 * null
 * zero
 * undefined
 * false
 */

// if("0"){console.log('empty string')}else{console.log('empty')}

// var num = ""+0
// num = "" + true
// num = 5 + true

// var res = confirm('Are you sure?')

//function without return statement---return ----undefined
//function statement-declarative function
var mydata = 10
console.log(fun(1,2))
function fun(x,y){
    //private scope/local scope/function scope
    console.log(arguments)
    var sum = x+y+mydata
    myval = 2
    // console.log(sum)
    return sum
}