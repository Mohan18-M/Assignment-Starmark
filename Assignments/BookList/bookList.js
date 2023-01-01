function addBook(){
    const n=document.getElementById("txtbook");
    if(n.value==="")
    {
        alert("no input entered")
    }
    else{
    const ol=document.getElementById("olbook");
    ol.innerHTML+="<li>"+n.value+"</li>";
    }
    
}
