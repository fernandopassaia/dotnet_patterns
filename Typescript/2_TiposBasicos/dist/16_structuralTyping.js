"use strict";
// falo que minha função é do tipo VerifyUserFn e vai receber um user e um sentValue
//
var verifyUser = function (user, sentValue) {
    return (user.username === sentValue.username && user.password === sentValue.password);
};
var bdUser = { username: 'joao', password: '123456' };
var sentUser = { username: 'joao', password: '123456', permissions: '' };
var loggedIn = verifyUser(bdUser, sentUser);
console.log(loggedIn);
