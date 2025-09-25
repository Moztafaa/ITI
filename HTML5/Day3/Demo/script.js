//get canvas element
var canvas = document.getElementById('myCanvas')
//define context--2d---(3d----webgl)
var context = canvas.getContext('2d')
// context.beginPath()
// context.moveTo(10,50)
// context.lineTo(200,10)
// context.lineTo(50,100)
// // context.lineTo(10,50)
// context.closePath()
// context.lineWidth = 4
// context.strokeStyle='red'
// context.fillStyle = 'yellow'
// context.stroke()
// context.fill()
//stroke
//fill


// context.arc(300,150,50,0*Math.PI,2*Math.PI)
// context.stroke()


// context.rect(0,0,200,100)
// context.stroke()


// context.fillStyle = 'blue'
// context.fillRect(250,110,100,100)

// context.strokeRect(250,200,200,100)

// context.font="26px Georgia"
// context.strokeText('This is a canvas Demo!',0,50)


// var grd = context.createLinearGradient(0,0,0,100)
// var grd = context.createLinearGradient(0,0,200,100)
var grd = context.createRadialGradient(200,100,50,150,50,150)
grd.addColorStop(1,'blue')
grd.addColorStop(0.5,'red')
grd.addColorStop(0,'green')

context.fillStyle = grd
context.fillRect(0,0,300,200)
context.strokeRect(0,0,200,100)

// context.translate(100,100)
// context.rotate(20*Math.PI/180)
context.translate(100,350)
context.rotate(90*Math.PI/180)
context.translate(-100,-350)
context.fillRect(0,300,200,100)
// context.translate(-100,-100)
context.setTransform(1,0,0,1,0,0)
context.fillStyle = 'red'
context.fillRect(0,300,200,100)

// context.arc(200,100,50,0,2*Math.PI)
// context.stroke()
// context.arc(150,50,150,0,2*Math.PI)
// context.stroke()