"use strict";
/* Recomendado */
// Condicional
var body1 = document.querySelector('body');
if (body1)
    body1.style.background = 'red';
// Type assertion
var body3 = document.querySelector('body');
body3.style.background = 'red';
// HTMLElement
var input = document.querySelector('.input');
input.value = 'Qualquer coisa';
input.focus();
/* Não Recomendado */
// Type assertion
var body4 = document.querySelector('body');
// Non-null assertion (!)
var body2 = document.querySelector('body');
body2.style.background = 'red';
