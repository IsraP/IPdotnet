// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function formOnFail(err){
    if(err && err.status == 500)
        toastr.err(err.responseText);
}