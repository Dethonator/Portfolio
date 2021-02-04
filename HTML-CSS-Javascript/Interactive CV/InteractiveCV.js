//definition of content element/children
var content = document.getElementsByClassName("content");
var arrContent = Array.from(content);

//suggested debugging addition
console.log("Content:" + arrContent.length);

//definition of onclick events 
function setClickEvent(elementId, callBack){
    document.getElementById(elementId).onclick = callBack;
}

setClickEvent("btnProfile", navOption(0));
setClickEvent("btnSkills", navOption(1));
setClickEvent("btnEducation", navOption(2));
setClickEvent("btnEHistory", navOption(3));
setClickEvent("btnHobbies", navOption(4));
setClickEvent("viewAll", viewAll())

//function to hide all but requested content section
function navOption(id){
    for(var i = 0; i < content.length; i++){
        if(id != i+1){
            content[i].style.display="none";
        }
        else{
            content[i].style.display="block";
        }
    }
    
}

//function to view all
function viewAll(){
    for(var i = 0; i < content.length; i++){
        content[i].style.display="block";
    }
}