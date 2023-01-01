// class User{
//     constructor(uname,pass)
// }
class foodItem{
    constructor(id,name,count,amount)
    {
        this.id=id;
        this.name=name;
        this.count=count;
        this.amount=amount;
    }
}

class food{
    // items=[{"biriyani":200},{"Burger":80},{"Prota":200},{"biriyani":200}]
    items=[];
    constructor()
    {
    this.items.push(new foodItem(1,"biriyani",0,200))
    this.items.push(new foodItem(2,"Burger",0,200))
    this.items.push(new foodItem(3,"Prota",0,80))
    this.items.push(new foodItem(4,"Gobi",0,100))

    }
    
    addFood=(id,count)=>{
       const a= this.items.find(e=>e.id===id)
       a.count=count;
       a.amount=a.amount*a.count;
    }

}
const obj1=new food();
const obj2=new food();