var arr = [2, 6, 9, 0];
var result = arr.filter(function (num) { return num > 5; });
console.log(result);
result.forEach(function (n) { return console.log(n); });


// reducer demo 
var result1 = arr.reduce(function (acl, num) { return acl + num; }, 0);
console.log("result is", result1);
