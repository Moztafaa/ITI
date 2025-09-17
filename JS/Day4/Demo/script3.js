//DOM-Document Object Model-standard function,properties
//document

// document.getElementById//first match
// document.getElementsByTagName//select all elements with same tag
// document.getElementsByClassName//select all elements have same class name
console.log(document.getElementById('h1id'))
var elem = document.getElementById('h1id')//javascript object
//attribute---->property
var elem1 = document.getElementsByTagName('p')
// elem.innerText="new text"
elem.innerHTML="<i>new text</i>"

var elem2 = document.getElementsByClassName('c1')
// elem2.style = "color:red"//XXXXXXXXXXXXXXXXXXS