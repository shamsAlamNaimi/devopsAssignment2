// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(
    $.get( "https://localhost:5001/BillyJoel", function(res) {
        $('#bj-lyrics').html(res.data);
  }),

  $.get( "https://localhost:5001/Beatles", function(res) {
        $('#bt-lyrics').html(res.data);
  }),

  $.get( "https://localhost:5001/Wcmt", function(res) {
        $('#wc-lyrics').html(res.data);
  })





);
