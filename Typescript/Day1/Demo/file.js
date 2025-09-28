// const val = 1
// console.log(val)
// const x = 2
//Basics DataTypes
//string,boolean,number
// let add:number = 1
// console.log(typeof add)//number
// add = "string"
// add = true
let fname = "ahmed";
// fname = 1XXX
function add(arg1, arg2) {
    return arg1 + arg2;
}
const a1 = 2;
const a2 = 3;
const r1 = add(a1, a2);
console.log(r1);
// const a3 = "hello"
// const a4 = " world"
// const r2 = add(a3,a4)
// console.log(r2)
function concatenate(arg1, arg2) {
    return arg1 + arg2;
}
const a3 = "hello";
const a4 = " world";
const r2 = concatenate(a3, a4);
// const r3 = concatenate(a1,a2)
function check(arg) {
    if (arg > 2) {
        return false;
    }
    return true;
}
let arr = [1, 2, 3];
// arr=['str','test']
arr = [2, 6, 7];
let arr2 = ['str', 'test'];
console.log(arr);
console.log(arr2);
function printArray(arr) {
    // console.log(arr)
    // arr.forEach(elem=>console.log(elem))
    console.log(arr[0]);
    console.log(arr[1]);
    console.log(arr[2]);
}
arr = [1, 2];
// printArray(arr)
arr = [1, 2, 3, 4];
// printArray(arr)
// printArray(27)
//Tuple
const myarr = [1, 2, 3];
printArray(myarr);
// let p2
// p2 = 1
// p2 = "str"
// p2 = true
let x = [1, ''];
// x=[1,2]
// x=['test',4]
//array --length = 0
// let y :[number] = [1,2,3]
// console.log(y)
// let y:(number|boolean|string[])[] = [5,true,['str']]
// y = [1,2,3]
// // y = ['str','test',true]---[[string],[string],boolean]
// y=[true,false,true]
// y=[['str','tst'],['hello']]
// y=[1,true]
// let NewArray:any[] = []
const user1 = {
    name: 'ahmed',
    age: 20,
    courses: ['c#', 'C++', 'python'],
    test: ""
};
const user2 = {
    name: 'ali',
    age: 27,
    courses: ['java', 'python']
};
// console.log(user1)
// console.log(user2)
// user1.name = "mohamed"
// console.log(user1)
// user1.test = 'xyz'
function printUser(user) {
    console.log(user.name);
}
printUser(user1);
printUser(user2);
//Union Type
function addConcate(arg1, arg2) {
    if (typeof arg1 === 'number' && typeof arg2 === 'number')
        return arg1 + arg2;
    if (typeof arg1 === 'string' && typeof arg2 === 'string')
        return arg1 + arg2;
    return;
    // return arg1+arg2
}
console.log(addConcate(1, 2));
console.log(addConcate(1, "2"));
function printValues(arg1, arg2) {
    console.log(arg1);
    console.log(arg2);
}
printValues(1, "test");
//interfaces
// interface IUser{
//     name:string;
//     age:number;
//     courses:string[]
// }
// interface UserExtend extends IUser{
//     permissionLevel:string
// }
// const user3:IUser={
//     name:'ahmed',
//     age:20,
//     courses:['c#'],
//     // test:"dfsdf"
// }
// const user4:UserExtend={
//     name:'ali',
//     age:20,
//     courses:['c'],
//     permissionLevel:'Instructor',
//     // test:'hi'
// }
// console.log(typeof user4)
var PermissionValues;
(function (PermissionValues) {
    PermissionValues[PermissionValues["Instructor"] = 0] = "Instructor";
    PermissionValues[PermissionValues["Student"] = 1] = "Student";
    PermissionValues[PermissionValues["Admin"] = 2] = "Admin";
})(PermissionValues || (PermissionValues = {}));
const myUser = {
    name: 'ahmed',
    age: 20,
    courses: ['c'],
    permissionLevel: PermissionValues.Student
};
console.log(myUser);
const p1 = {
    name: 'ahmed',
    age: 20,
    address: ''
};
console.log(p1);
// p1.name = 'mohamed'
p1.age = 20;
console.log(p1);
let emp1 = {
    name: "string",
    email: "string",
    salary: 20
};
let emp2 = {
    name: "ali", email: "xyz"
};
console.log(emp2);
let emp3 = {
    name: 'ali',
    email: 'xyz',
    salary: 20,
    isMale: true
};
let emp4 = {
    name: 'Mohamed',
    email: "dfds@fdf.com",
    salary: 5555,
    isMale: true
};
// emp4.salary=0//readonly property
let Student = {
    name: 'Ali',
    email: "test",
    // salary:20//error not exist
};
let s1 = {
    name: 'ahmed',
    salary: 222
};
var sections;
(function (sections) {
    sections[sections["HR"] = 0] = "HR";
    sections[sections["Dev"] = 1] = "Dev";
    sections[sections["DevOps"] = 2] = "DevOps";
})(sections || (sections = {}));
// type sections = "HR"|"Dev"|"DevOps"
// let deptSec:Extract<sections,sections.Dev|sections.HR>=sections.DevOps
// let myDept:Exclude<sections,("HR")>="DevOps"
