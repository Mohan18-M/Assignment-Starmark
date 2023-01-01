const toUSD=(x,contry)=>{
    switch (contry){
        case 'ind':
            return (x*0.012);
        case "uk":
            return x * 1.24;
        case "qt":
            return x * 0.27;
        default :
            return x;
}
}
const finallConvertion=(x,contry)=>{
    
    switch (contry){
        case "ind":
            return x*82.64;
        case  "uk":
            return x * 1.24;
        case  "qt":
            return x *3.67;
        default :
            return x;
}
}


const convert=()=>{
    let inNo=parseFloat(document.getElementById("txtin").value);
    let from=document.getElementById("from").value;
    let to=document.getElementById("to").value;
    console.log(inNo)
    console.log(from)
    console.log(to)
    
    document.getElementById("txtres").value= finallConvertion(toUSD(inNo,from),to);

}