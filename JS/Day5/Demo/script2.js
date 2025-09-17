document.getElementsByTagName('form')[0].onsubmit = function(event){
    console.log(event)
    if(!confirm('Are you sure?')){
        // return false
        event.preventDefault()
    }
}