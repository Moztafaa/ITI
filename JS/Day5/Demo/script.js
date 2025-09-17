onload = function(){
    var elem = document.getElementById('h1id')
    elem.innerHTML += 'Dot Net'
    // document.getElementsByTagName('input')[0].onclick = function(){
    //     fun()
    // }
    var elements = this.document.getElementsByTagName('img')
    for(var i=0;i<elements.length;i++){
        elements[i].onmouseover = changeSource
        elements[i].onmouseout = changeSource
    }
}

var flag = true
function fun(){
    // alert('hi')
    // return 'test'
    // if(flag){
    //  val = document.getElementById('txt1').value
    // document.getElementById('txt1').value=""
    // var elem ="*".repeat(val.length)
    // document.getElementById('txt1').value = elem
    // flag = false
    // }
    // else{
    //     document.getElementById('txt1').value = val
    //     flag = true
    // }
    if(flag){
        document.getElementById('txt1').type = 'password'
        flag = false
    }
    else{
        document.getElementById('txt1').type = 'text'
        flag= true
    }
}


var changeImg = true
function changeSource(event){
    // console.log(this)
    console.log(event)
    if(changeImg){
        this.src = 'Images/marshall_c.jpg'
        // img.src = 'Images/marshall_c.jpg'
        // document.getElementsByTagName('img')[idx].src = 'Images/marshall_c.jpg'
        changeImg = false
    }
    else{
        this.src = 'Images/marshall_bw.jpg'
        // img.src = 'Images/marshall_bw.jpg'
        // document.getElementsByTagName('img')[idx].src = 'Images/marshall_bw.jpg'
        changeImg = true
    }
}

function returnSource(){
    document.getElementsByTagName('img')[0].src = 'Images/marshall_bw.jpg'

}



// document.getElementsByTagName('img')[0].onmouseover = function changeSource(img){
//     // console.log(this)
//     console.log(img)
//     if(changeImg){
//         this.src = 'Images/marshall_c.jpg'
//         // img.src = 'Images/marshall_c.jpg'
//         // document.getElementsByTagName('img')[idx].src = 'Images/marshall_c.jpg'
//         changeImg = false
//     }
//     else{
//         this.src = 'Images/marshall_bw.jpg'
//         // img.src = 'Images/marshall_bw.jpg'
//         // document.getElementsByTagName('img')[idx].src = 'Images/marshall_bw.jpg'
//         changeImg = true
//     }
// }







