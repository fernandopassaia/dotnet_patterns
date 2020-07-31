"use strict";
const adder = (x, y, ...args) => {
    if (args.length > 0)
        return args.reduce((s, v) => s + v, 0) + x + (y || 0);
    return x + (y || 0);
};
console.log(adder(1));
console.log(adder(1, 2));
console.log(adder(1, 2, 3));
//# sourceMappingURL=05_OverloadMetodosFuncoes.js.map