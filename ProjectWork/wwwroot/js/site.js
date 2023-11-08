// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var show_con_btn = document.getElementById("show_con_btn");
var hidden_content = document.getElementById("hidden_content");

show_con_btn.addEventListener("click", function() {
  if(hidden_content.style.display == "none" || hidden_content.style.display === "") {
    hidden_content.style.display = "block";
    show_con_btn.innerHTML = "Back";
    show_con_btn.style.cursor = "pointer";
  }else {
    hidden_content.style.display = "none";
    show_con_btn.innerHTML = "Sort";
  }
});
