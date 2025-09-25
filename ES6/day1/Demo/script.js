//let const  vs var
//scope

// for (let i = 0; i < 5; i++) {
//     console.log(i);//0 1 2 3 4
// }

// {
//     let y = 20;
// }
// console.log(y);
// console.log(i);//5


//hoisting
//var x;
// debugger;
// console.log(x);
// var x = 10;

// console.log(x);
//   x = 10;

// function test(){
//     //var x;//local
//     console.log(x);//10
//     let x = 10;
// }
// //var x = 20;
// var x = 20;//global
//  test();


//redclaration
// var y = 20;
// let y = 50;//y=50

// var x = 5;
// var x = 10;

/////let vs const

// function test(n){
//     let msg;
//     const age = 25;
//     if(n){
//      //   age = 25;
//         // msg = "my name is " + n + "iam "+ age+ "years old";
//         msg = `my "name" is ${n} i am ${2025-1996} 'years' old`;

//     }
//     console.log(msg);

// }

//  test("menna")

// const arr = [1,2,3];
// arr.push("end");

// arr = 5;//error

// var str = "menna";
// console.log(str.startsWith("Me"));

//arrow function
// var myfunc = function(x,y){
//     return x+y;

// }
// var myfunc = (x,y)=>x+y;

// console.log(myfunc(10,10));

//
//this keyword
// var obj = {
//     name:"menna",
//     age:25,
//     print:function(){
//         //this==obj
//         //this pattern
//         //var self = this;
//         window.setTimeout(()=>{
//             console.log(this.name,this.age);
//         },1000);
//     }
// }

// obj.print();

////////destruct///////////

// var arr = [200,100,300];

// // var a1 = arr[0];

// // var a2 = arr[1];
// var [a1,,a2] = arr;
// var x = 1000;
// var [max,min,y] = [x,1];

//destruct by obj

// var obj = {
//     name:"menna",
//     age:25
// }
// //  var age = obj.age
// // console.log(age);

// var {age,name:objName} = obj;

// window.addEventListener("click",function({target:t}){
//     console.log(t);

// })

//// rest parameters  ...  spread operator

// function test(a,...x){
//     console.log(a,x);
// }
// test(100,200);
// test(100,300,60);
// test(30);

//  var arr= [100,200,300];
// // var arr2 = [400,500,600];
// var arr3 = [...arr,...arr2]//[100,200,300,400,500,600]
// console.log(arr3);

// console.log(Math.max(...arr));

//array copy
// var newCopy = [...arr];
// newCopy.push("end");
// console.log(newCopy);
// console.log(arr);

////////////array methods////////////////////
var arr = [1996,2010,2006,1994];

//loop condition return newarr
// var newArr = arr.filter(el=>el>1996);

// var ele = arr.find(el=>el>2010);

// var Index = arr.findIndex(el=>el>2006);


// //loop 2025-arr[i] newArr with elements
// //Map
// var newElments = arr.map((el)=>{
//    return 2025 - el;
// })

// var res = Array.from("menna");
// console.log(res);