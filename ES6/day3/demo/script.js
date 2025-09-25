//factroy classes
var arr = new Array();
// class Array
//function is the first class Object
// var obj = {
//     name:"menna",
//     age:25
// }
// var obj2 = {
//     name:"hamada",
//    age:25
// }
// function Employee(n,a=0){
//     console.log(this);
//     if(!n){
//         throw("error you should enter name");
//     }
//     this.name = n;
//     this.age=a;
//     // this.print = function(){
//     //     console.log(this.name,this.age);
//     // }
// }
// Employee.prototype.print = function(){
//     console.log(this.name,this.age);
// }//object
//function caller
//es6 syntax
 class Employee{
    //optional 
    name;
    age;
    //private memeber not optional
    #year;
    constructor(n,a=0,y=0){
        if(!n){
            throw("error you should enter name");

        }
        this.name = n;
        this.age = a;
        this.#year = y;
        
    }
    get getYear(){
        return this.#year + 10;

    }
    set setYear(value){

        this.#year = value;
    }
    print(){
            console.log(this.name,this.age);
        }
   //static methode
   static myStaticMethode(){
    console.log("this is a static method");
   }
}
//call static method
Employee.myStaticMethode();
class StaticClass{
  constructor(){
    throw("this is a static class");

     }
    static test(){
        console.log("hello");
    }
}
// var m = new StaticClass();
StaticClass.test();
//////////////////////
var emp =  new Employee("menna",25,1994);
emp.name = 30;
//getter setter
// emp.print();
console.log(emp.getYear);
var emp2 = new Employee("hmada");
// emp2.year = 10;
console.log(emp2.getYear);
emp2.setYear = 1900;
// emp2.print();
console.log(emp2);

// console.log(emp.constructor === emp2.constructor);
// console.log(emp.constructor===Employee);//{constructor:Employee}
