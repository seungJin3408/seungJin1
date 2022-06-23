const express = require('express') // express 모드를 가져온다.
const app = express() // express app을 실행
const port = 5000 // port
const mongoose = require('mongoose')
mongoose.connect('mongodb+srv://game3408:06050302zxc@seungjin.j1wfdzu.mongodb.net/?retryWrites=true&w=majority')
  .then(()=>console.log('mongodb connected...'))
  .catch(err => console.log(err))


app.get('/',(req,res) => res.send('hello world'))
app.listen(port,()=> console.log('example app listening on port {1}!',port))