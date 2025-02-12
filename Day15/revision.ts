// 1. Type Annotations
let userName: string = "John";
let age: number = 25;
let isStudent: boolean = false;


function greet(name: string): string {
    return `Hello, ${name}!`;
}

console.log(greet(userName));


interface Person {
    name: string;
    age: number;
    isStudent: boolean;
}

let person: Person = {
    name: "Alice",
    age: 22,
    isStudent: true
};

console.log(`${person.name} is ${person.age} years old.`);

//  Class with Constructor and Methods

class Car {
    brand: string;
    model: string;
    year: number;

    constructor(brand: string, model: string, year: number) {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    getCarInfo(): string {
        return `${this.brand} ${this.model} (${this.year})`;
    }
}

let myCar = new Car("Toyota", "Corolla", 2022);
console.log(myCar.getCarInfo());

//  Union Types
function printId(id: number | string): void {
    console.log(`ID: ${id}`);
}

printId(101);
printId("A102");

//  Optional Properties
interface Employee {
    id: number;
    name: string;
    department?: string; 
}

let emp1: Employee = { id: 1, name: "Bob" };
let emp2: Employee = { id: 2, name: "Alice", department: "HR" };

console.log(emp1, emp2);

// Generics
function getFirstElement<T>(arr: T[]): T {
    return arr[0];
}

let numbers = [1, 2, 3, 4];
let names = ["Alice", "Bob", "Charlie"];

console.log(getFirstElement(numbers)); 
console.log(getFirstElement(names)); 
