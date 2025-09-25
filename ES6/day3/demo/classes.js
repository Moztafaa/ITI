//Employee name age salary  print()  calcSalary(b);
//Student  name age grades  print()  calcGrades();

//User name age print();//parent
//abstract class
class User{
    constructor(n,a=0){
        if(this.constructor ===User){
            
            throw("error abstract class")
        }
        if(!n){
            throw("error")
        }
        this.name = n;
        this.age = a;
    }
    print(){
        console.log(this.name,this.age);
    }
}
//  var u = new User();//{consrunctor:User}

 export class Employee extends User{
    constructor(n,a,s){
        super(n,a);
        this.salary = s;

    }

    calcSalary(b){
        return this.salary + b;

    }

    //override
    toString(){
        //  super.print;//forbddin
        return this.name
    }
}

 export default class Student extends User{
    constructor(n,a,g){
        super(n,a);
        this.grades = g;
    }

    calcGrades(){
        return this.grades + "%";
    }
}


// console.log("hello");
// export {Employee,Student};


// var arr = [1,2,3];
// console.log(arr.toString());

// function test(){
//     var x = 10;
//     console.log("hello");
// }

// var res = test();
// console.log(res);