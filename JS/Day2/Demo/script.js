/**4 main categories
 * 1)Custom Object
 * 2)Built-in Objects
 * 3)BOM---Brawser Object Model
 * 4)DOM---Document Object Model
 */

/**Built-in Objects
 * String
 * Number
 * Boolean
 * Date
 * Array
 * Math
 * Object
 * Error
 * Function
 * Event
 * Regexp
 */

//String
// //literal way creation----primitive datatype
// var str = '    Hello world nice day          '
// console.log(str)//'text'
// console.log(typeof str)//string
// //constructor way
// var mystr = new String('my text demo abc')
// console.log(mystr)
// console.log(mystr[0])
// mystr[0]='x'
// console.log(mystr[0])
// var test = mystr.replace(' ','_')
// console.log(mystr.split(' '))
// console.log(mystr.indexOf('t'))//index--first match
// console.log(str.lastIndexOf('t'))//index-- last match
// console.log(str.toUpperCase())
// console.log(str.includes('exy'))//true or false

// // console.log(str.repeat(-1))//range error minimum value = 0
// console.log(str.search('l_'))//-1--->not found
// console.log(str.search('ni'))//-1--->not found
// console.log(str.trim())
// console.log(str.trimLeft()+'...')
// console.log(str.trimRight()+'...')


//Number
//literal way
// var x = 1
// console.log(x)//1
// console.log(typeof x)//number
// var num = new Number(12.35496872145)
// console.log(num)
// console.log(typeof num)
// console.log(num.toString())
// console.log(num.toFixed(5))
// console.log(Number.MAX_VALUE)
// console.log(Number.MIN_VALUE)
// console.log(Number.NaN)
// var x = Number.NaN
// y = Number.NaN

// Number.isNaN(x)//replace == operator NaN
// isNaN//window object----check value numeric or not----isFinite

//Math Object
//static class
// console.log(Math.SQRT1_2)
// console.log(Math.SQRT2)
// console.log(Math.sqrt(16))
// console.log(Math.min(1,7,20,-1))
// console.log(Math.round(0.467))
// console.log(Math.ceil(0.467))
// console.log(Math.cos(90*Math.PI/180).toFixed(4))
// Math.

//Array Object
//literal way
var myArray =['test',true,6,""]
console.log(myArray[0])
console.log(myArray[10])
myArray[20]=1
console.log(myArray.length)
myArray.push(2)

//constructor way
var arr = new Array(5)
// var arr = new Array(1,2,3)
// var arr = new Array("str")

var val = myArray.pop()//deleted value from last index

// arr=[1,2,3]
// arr[7]=5
myArray.unshift(-1)

// var arr2 = myArray
// arr2[0]='new data'
var arr2= []
for(var i=0;i<myArray.length;i++){
    arr2[i]=myArray[i]
}

arr = [1,2,10,11,3,5,7,22,12]
arr.sort()//function comparison

arr = []
//Associative array
arr['skills']='JS'
arr['grade']=5

var arr2 = []
// for(var i=0;i<arr.length;i++){
//     arr2[i]=arr[i]
// }
//iterate enumerable keys
for(var elem in arr){
    console.log(elem)
    arr2[elem]=arr[elem]//XXXXXXXXXXXXXXXXXXXXXX
}
// console.log(arr['skills'])//subscript notation
// console.log(arr.skills)//dot notation
// console['log']('hello')




// Ahmed Mohamed
// a
// A


RADAR
RAdar
mona

















