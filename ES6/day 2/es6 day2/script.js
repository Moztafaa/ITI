// function first(){
//     console.log("first");
//     second();
//     console.log("end");
// }

// function second(){

//     setTimeout(() => {

//         console.log("second");
//     }, 1000);
// }

// first();

// var x;
// setTimeout(() => {
//     x=10;

// }, 10);

// for(var i=0;i<100000000;i++){

// }
// console.log(x);

// setTimeout(() => {
//     for(var i=0;i<100000;i++){

//     }
//     awettr
//     console.log("first");

// }, 1000);

// setTimeout(() => {
//     console.log("second");

// }, 1000);
//callback hell
// var ids;
// setTimeout(() => {
//     //creation data
//     ids = [100, 200, 300];
//     //using data
//     console.log(ids);

//             setTimeout(() => {
//                 //creation data
//                 var user = {
//                     id: ids[2],
//                     name: "menna"

//                 }
//                 //using data
//                 console.log(user);
//                             setTimeout(() => {
//                                 //create data
//                                 var address = {
//                                     userName: user.name,
//                                     city: "ismailia"
//                                 }
//                                 //using data
//                                 console.log(address);

//                             }, 10);

//             }, 500);

// }, 1000);


///pattern promises
// console.log("first");
// var p = new Promise(function (resolve,reject){
//   setTimeout(() => {
//     //creation data
//     var num;
//     if(num){

//         resolve(num);
//     }
//     else{
//         reject("error in getting data");
//     }
//   }, 1000);
// });

// p.then((x)=>{
//     //use data
//     console.log(x);
// }).catch((e)=>{
//     console.log(e);
// })


///////////////
// var getIds = new Promise((res, rej) => {
//     setTimeout(() => {
//         var ids;
//         // = [100, 200, 300];
//         if (ids) {
//             res(ids);
//         }
//         else {
//             rej("error to get ids");
//         }

//     }, 1000);

// });
/////////////get user
// function getUser(userID) {
//     return new Promise((res, rej) => {
//         setTimeout(() => {
//             var user = {
//                 id: userID,
//                 name: "hamada"
//             }
//             if (user) {
//                 res(user)
//             }
//             else {
//                 rej("error in get User")
//             }

//         }, 500);
//     })
// }
// //get address
// function getAddress(userName) {
//     return new Promise((res, rej) => {
//         setTimeout(() => {
//             var address = {
//                 name: userName,
//                 city: "hamada"
//             }
//             if (address) {
//                 res(address);
//             }
//             else {
//                 rej("error to get address")
//             }
//         }, 1000);
//     })
// }
// ///es8 async await
// async function test() {
//     try {
//         var ids = await getIds;
//         console.log(ids);
//         var user = await getUser(ids[1]);
//         console.log(user);
//         console.log(await getAddress(user.name));

//     }
//     catch (e) {
//         alert(e);

//     }


// }

// console.log("first");
// test();

// (async function(){
//  var ids = await getIds;
//     console.log(ids);
// })();
// getIds.then((arr) => {
//     //using ids
//     console.log(arr);
//     return getUser(arr[1]);
// })
// .then((u)=>{
//     //using user
//     console.log(u);
//     return getAddress(u.name);
// })
// .then((a)=>{
//     console.log(a);
// })
// .catch((e) => {
//         alert(e);

// })



//ajax request syntax
//native code
//es6  fetch
//jquery syntax
//angular
//async javascript and xml request
{/* <employee>
    <name>hamada</name>
    <age>25</age>
</employee>

//json   js object noation
`{"name":"hamada",
   "age" :"25"
}`

JSON.parse(jsonObject);//convert from json to js object

var obj = {
    name:"hamada",
    age:25
}
JSON.stringify(obj);//convert from js to json */}

////////////fetch

//var res = fetch("https://jsonplaceholder.typicode.com/users");
// console.log(res);
// //then catch
// res.then((resp)=>resp.json())
// .then((users)=>{
//         console.log(users);

//     })

//async await
var users;
async function getUsers() {

    var res = await fetch("https://jsonplaceholder.typicode.com/users");
    users = await res.json();//convert from json to javascript;
    usersData(users);
}

getUsers();

function usersData(users){
    users.forEach(element => {
        console.log(element.name);
        
    });

}