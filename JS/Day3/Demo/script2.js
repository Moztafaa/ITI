/**BOM-Brawser Object Model--- window */
var win
function OpenNewPage(){
    // open('','')
    // open('demo2.html','_self')
    // win = open('http://www.google.com','','width=300,height=300')
    win = open('demo2.html','','width=300,height=300')
    console.log(win)
}

function MoveNewPage(){
    // win.moveTo(200,300)
    if(win){
    win.moveBy(20,20)
    win.focus()
    }
}


function ResizeNewPage(){
    if(win){
        // win.resizeBy(20,20)
        win.resizeTo(400,400)
        win.focus()
    }
}

function closeWindow(){
    win.close()    
}