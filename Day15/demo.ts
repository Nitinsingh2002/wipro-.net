var a: string = "hello";
console.log(a);


var unionValue: string | boolean = true;

//tuple example 
let person: [number, string] = [1, "nitin"]
console.log(person[0]);
console.log(person[1]);



//
const numbers: number[] = [1, 2, 4, 6];
const newNumbers :number[] = [...numbers,89,19];
console.log(numbers);
console.log(newNumbers);





function add(a: number, b: number): number {
    return a + b;
}


