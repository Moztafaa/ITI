function addText(elem){
    document.getElementById('txt1').value += elem.value
}

document.getElementById('clearBtn').onclick = function(){
    document.getElementById('txt1').value = ""
}

document.getElementById('lastelem').onclick = function(){
    var elem =  document.getElementById('txt1')
    elem.value = elem.value.substring(0,elem.value.length-1)
}