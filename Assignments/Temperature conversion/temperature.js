

const callF=()=>{
    let cel=prompt("Enter Temperature")
    if(cel===null)
        return
    if(Number.isNaN(parseFloat(cel)))
    {   alert("Wrong input given "+cel+"\n Do you want to try once more RELOAD")    
    }
    else
    {   
    if(confirm(cTF(parseFloat(cel))+"F Faranhit\n do you want to try one more time"))
    {
        callF()
    }
    }

}
const cTF=(x)=>(x*9/5)+32
callF()

