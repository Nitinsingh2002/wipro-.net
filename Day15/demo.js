var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
var a = "hello";
console.log(a);
var unionValue = true;
//tuple example 
var person = [1, "nitin"];
console.log(person[0]);
console.log(person[1]);
//
var numbers = [1, 2, 4, 6];
var newNumbers = __spreadArray(__spreadArray([], numbers, true), [89, 19], false);
console.log(numbers);
console.log(newNumbers);
function add(a, b) {
    return a + b;
}
