// document.getElementsByClassName("parent")[0].onclick = function () {
//   console.log("parent one");
// };
// document.getelementsbyclassname("parent")[0].onclick = function () {
//   console.log("test");
// };
// document.getElementsByClassName("child")[0].onclick = function () {
//   console.log("child");
// };

// document.getElementsByClassName("lastchild")[0].onclick = function (event) {
//   console.log("lastchild");
//   event.stopPropagation();
// };

/**addEventListener */
//[f1,f2]
// document.getElementsByClassName('parent')[0].addEventListener('click',function(event){
//     console.log('parent')
//     // event.stopImmediatePropagation
//     // event.stopPropagation()
//     console.log(event)
//     // event.stopImmediatePropagation()
// })//capture mode
// document.getElementsByClassName('parent')[0].addEventListener('click',fun)

// function fun(){
//     console.log('parent..........')
//     document.getElementsByClassName('parent')[0].removeEventListener('click')
// }
// document.getElementsByClassName('parent')[0].addEventListener('mouseover',function(event){
//     console.log('mouse over event')
//     // event.stopPropagation()
//     // event.stopImmediatePropagation()
// Adds the first listener
// This listener is in the CAPTURE phase
document.getElementsByClassName("parent")[0].addEventListener(
  "click",
  function () {
    console.log("parent captures");
  },
  true
);

// This listener is in the BUBBLE phase
document
  .getElementsByClassName("lastchild")[0]
  .addEventListener("click", function () {
    console.log("lastchild bubbles");
  });
// })

// document.getElementsByClassName('child')[0].addEventListener('click',function(){
//     console.log('child')
// },true)

// document.getElementsByClassName('lastchild')[0].addEventListener('click',function(){
//     console.log('lastchild')
// })

// window.addEventListener('load',function(){
//     this.document.getElementsByTagName('h1')[0].innerHTML+=" dot net"
// })
// onload=function(){}

//1)instance event object
var myEvent = new Event("test");

var obj = document.getElementsByTagName("h1")[0];
// var obj={}
obj.addEventListener("test", function () {
  console.log("custom event");
});

// var result = parseInt(prompt('Enter your value'))
// if(result>50){

//     //3)Fire Event
//     obj.dispatchEvent(myEvent)
// }

document.getElementById("btn").onclick = function () {
  var val = parseInt(document.getElementById("txt1").value);
  if (val > 50) {
    obj.dispatchEvent(myEvent);
  }
};
