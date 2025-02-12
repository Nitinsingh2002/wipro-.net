var arr: number[] = [2, 6, 9, 0];

var result: number[] = arr.filter((num) => num > 5);
console.log(result);

result.forEach((n) => console.log(n));





// reducer demo 

var result1 = arr.reduce((acl,num)=>acl +num,0);
console.log("result is",result1);