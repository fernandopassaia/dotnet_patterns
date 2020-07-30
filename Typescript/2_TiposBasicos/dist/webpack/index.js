"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
// esse é meu arquivo de entrada TS no webpack, a partir dos imports aqui ele irá achar os outros (ver o webpack.config.js)
require("./mod");
var mod_1 = __importDefault(require("./mod"));
mod_1.default();
