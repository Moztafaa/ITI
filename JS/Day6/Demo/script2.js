document.getElementsByTagName('h1')[0].classList.add('c1')

document.getElementById('btn').onclick = function(){
    // document.getElementsByTagName('h1')[0].classList.toggle('c1')
    // document.getElementsByTagName('h1')[0].classList.remove('c1')
    // document.getElementsByTagName('h1')[0].classList.replace('c1','c2')
    // document.getElementsByTagName('h1')[0].classList.add('c2')
    // document.getElementsByTagName('h1')[0].style.color = 
    // document.getElementsByTagName('h1')[0].setAttribute('id','h1id')
    // document.getElementsByTagName('h1')[0].setAttribute('class','c2')
    // document.getElementById('img1').setAttribute('src','images/movingImg.gif')

    //current position
    var left = parseInt(getComputedStyle(document.getElementById('img1')).left)
    var x = 10
    setInterval(function(){
        left += 20
        document.getElementById('img1').style.left = (left)+"px"
    },500)
}


document.getElementById('btn2').onclick = function(){
    // var elem = document.createElement('p')
    // var txt = document.createTextNode('hello')
    // elem.appendChild(txt)
    // // document.body.prepend(elem)
    // document.body.insertBefore(elem,document.getElementById('img1'))

    // var span = document.createElement('span')
    // span.innerHTML = 'hello'

    // document.getElementsByTagName('p')[0].insertAdjacentElement('afterend',span)
    // var elem = document.createElement('script')
    // elem.type = 'text/javascript'
    // elem.src = 'script3.js'
    // document.getElementsByTagName('head')[0].appendChild(elem)


    document.getElementById('p1').onclick = function(){
        console.log('test')
    }


    var elem = document.getElementById('p1').cloneNode(true)

    document.body.appendChild(elem)





}