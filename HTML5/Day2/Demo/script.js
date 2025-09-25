// document.getElementById('btn').onclick = function(){
//     var usrnm = document.getElementById('usrnm').value
//     var usrage = document.getElementById('usrage').value


    
//     localStorage.setItem('usrnm',usrnm)
//     localStorage.setItem('usrage',usrage)
//     sessionStorage.setItem('visits',0)
//     // sessionStorage
// }

// //polyfill

// if(!window.localStorage){
//         var elem = document.createElement('script')
//         elem.src='storage.js'
//         document.getElementsByTagName('head')[0].appendChild(elem)
//     }


conditionizr.add('chrome',function(){
    return !!window.chrome
})

conditionizr.add('firefox',function(){
    return navigator.userAgent.indexOf('Firefox') !=-1
})


conditionizr.polyfill('chromeScript.js',['chrome'])
conditionizr.polyfill('firefoxScript.js',['firefox'])














