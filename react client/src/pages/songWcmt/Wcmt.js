import React from 'react'
import Paper from '@material-ui/core/Paper'
import ReactMarkdown from 'react-markdown'
import 'github-markdown-css'
import  { useState, useEffect } from 'react';

const Wcmt = () => {
    const [markdown, setmarkdown] = React.useState("no data found");
    useEffect(() => {
        fetch("https://localhost:5001/Wcmt")
        .then(function(response) {
          return response.json();
        })
        .then(res=> setmarkdown(res.data))
        .catch((err)=>console.log("error"));
      }, [])
  

  return (
    <Paper>
        <div style={{ backgroundColor: 'white', padding: 90 }}>
        <ReactMarkdown
            className="markdown-body"
            source={markdown}
            escapeHtml={false}
          />
        </div>
    </Paper>
  )
}
export default Wcmt
