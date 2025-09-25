document.getElementById('btn').onclick=function(){
    var obj={
        timeout:10000,
        enableHighAccurracy:true
    }
    navigator.geolocation.getCurrentPosition(successfn,errorHandler,obj)
}

function successfn(position){
    console.log(position)
    var coords = position.coords
    var lat = coords.latitude 
    var long = coords.longitude
    location.assign('http://maps.google.com/maps?q='+lat+",+"+long)
}

function errorHandler(err){
    switch(err.code){
        case 1:
            alert('Permission denied')
            break

    }
}