document.getElementById('btn').onclick = function(){
    var usrnm = document.getElementById('usrnm').value
    var usrage = document.getElementById('usrage').value

    document.cookie = "usrnm="+usrnm
    var date = new Date()
    date.setMonth(date.getMonth()+3)
    //document.cookie = "usrage="+usrage+";expires="+date.toUTCString()
    setCookie('usrage',usrage,date)
}