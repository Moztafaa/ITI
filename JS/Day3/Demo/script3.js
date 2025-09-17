console.log('start')
console.log('test')
var x = 1
// for(var i=0;i<10000;i++){}
var timer = setInterval(function(){
    console.log('new msg')
},5000)

console.log('cont..')
console.log('cont..')
console.log('cont..')
console.log('cont..')
console.log('cont..')


//Web API
//setTimeout
//setInterval

function stopTime(){
    clearInterval(timer)
    // clearTimeout//recusrive call
}