function displayContent(txt){
    document.getElementById('dv1').innerHTML = txt
}


document.getElementById('btn').onclick = function(){
    document.getElementById('dv1').innerHTML=""
    var selMenu = document.getElementById('selMenu')
    // var idx = selMenu.selectedIndex
    // document.getElementById('dv1').innerHTML = selMenu.options[idx].value
    // for(var i=0;i<selMenu.options.length;i++){
    //     if(selMenu.options[i].selected)
    //     {
    //         document.getElementById('dv1').innerHTML+=selMenu.options[i].value
    //     }
    // }
}