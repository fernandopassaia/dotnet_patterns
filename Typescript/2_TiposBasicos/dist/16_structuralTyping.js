"use strict";
var verifyUser = function (user, sentValue) {
    return (user.username === sentValue.username && user.password === sentValue.password);
};
var bdUser = { username: 'joao', password: '123456' };
var sentUser = { username: 'joao', password: '123456', permissions: '' };
var loggedIn = verifyUser(bdUser, sentUser);
console.log(loggedIn);
