function getAllCookies(){
    var data = []
    var info = document.cookie.split('; ')//[]
    for(var i =0;i<info.length;i++){
        // var key = info[i].split('=')[0]
        // var value = info[i].split('=')[1]
        // data[key]=value
        data[info[i].split('=')[0]]=info[i].split('=')[1]
    }

    return data
}

function getCookie(key){
    var arr = getAllCookies()
    if(arr[key]!=undefined){
        return arr[key]
    }
    else{
        return 'not found'
    }
}


function setCookie(key,value,expireyDate){
    if(expireyDate){//presisent Cookie
        document.cookie = key+"="+value+";expires="+expireyDate.toUTCString()
    }
    else{//session cookie
        document.cookie = key+"="+value
    }
}