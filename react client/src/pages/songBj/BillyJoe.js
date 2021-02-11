import React from 'react'
import Paper from '@material-ui/core/Paper'
import ReactMarkdown from 'react-markdown'
import 'github-markdown-css'
import  { useState, useEffect } from 'react';
import logo from '../../img/Billyjoel.jpg'

const BillyJoe = () => {
    const [markdown, setmarkdown] = React.useState("no data found");
    const [songname, setsongname] = React.useState("no song found");
    useEffect(() => {
        fetch("https://localhost:5001/BillyJoel")
        .then(function(response) {
          return response.json();
        })
        .then(res=> {setmarkdown(res.data); 
          setsongname(res.songName)})
        .catch((err)=>console.log("error"));
      }, [])

  return (
    <Paper>
        <div style={{ backgroundColor: 'white', padding: 90 }}>
        <img src={logo} style={{display: 'block',marginLeft: 'auto', marginRight: 'auto',width: '50%'}} alt="" /> <br />
        <h2>{songname}</h2>
        <ReactMarkdown
            className="markdown-body"
            source={markdown}
            escapeHtml={false}
          />
        </div>
    </Paper>
  )
}
export default BillyJoe
