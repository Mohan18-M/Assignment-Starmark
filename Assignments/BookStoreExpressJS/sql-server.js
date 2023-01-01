// that allows to register new books, display all books, find books, delete books


const app=require('express')();
const parser=require('body-parser');
app.use(parser.urlencoded({"extended":true}))
app.use(parser.json())

const config={server:'192.168.171.36',
database:'3322',
driver:'msnodesqlv8',
options:{
    trustedConnection:true,
    TrustServerCertificate:true
}
}
const server=require("mssql/msnodesqlv8");
const pool= new server.ConnectionPool(config)

app.get('/',(req,res)=>{
    res.sendFile(__dirname+'/bookStoreApp.html')
})

app.get('/getBook',(req,res)=>{
    pool.connect().then(()=>{
        pool.request().query('SELECT * FROM tblBooks',(err,result)=>{
            err?console.error(err):res.send(result.recordset)
        })
    }).catch(err=>{
        err?console.log(err):""
    })
})

app.get('/:id',(req,res)=>{
    const id=req.params.id
    pool.connect().then(()=>{
        pool.request().query(`SELECT * FROM tblBooks where bookId=${id}`,(err,result)=>{
            err?console.error(err):res.send(result.recordset)
        })
    }).catch(err=>{
        err?console.log(err):""
    })
})


app.post('/addBook',(req,res)=>{
    const body=req.body;
    console.log(body)
    pool.connect().then(()=>{
        pool.request().query(`insert into tblBooks values(${body.bookId},'${body.bookTitle}','${body.bookAuthor}',${body.bookPrice}) `,(err,result)=>{
            // err?console.error(err):res.send(body)
            err?console.error(err):res.redirect('/')
        })
    }).catch(err=>{
        err?console.log(err):""
    })
    
})
app.delete('/:id',(req,res)=>{
    const id=req.params.id;
    pool.connect().then(()=>{
        pool.request().query(`delete from tblBooks where bookId=${id}`,(err,result)=>{
            err?console.error(err):res.send(result);
            
        })

    }).catch(err=>{
        err?console.log(err):""
    })
})



app.listen(1111,()=>{console.log("server is running at port 1111");})