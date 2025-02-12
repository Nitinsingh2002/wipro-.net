// 1. Type Annotations
var userName = "John";
var age = 25;
var isStudent = false;
function greet(name) {
    return "Hello, ".concat(name, "!");
}
console.log(greet(userName));
var person = {
    name: "Alice",
    age: 22,
    isStudent: true
};
console.log("".concat(person.name, " is ").concat(person.age, " years old."));
//  Class with Constructor and Methods
var Car = /** @class */ (function () {
    function Car(brand, model, year) {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }
    Car.prototype.getCarInfo = function () {
        return "".concat(this.brand, " ").concat(this.model, " (").concat(this.year, ")");
    };
    return Car;
}());
var myCar = new Car("Toyota", "Corolla", 2022);
console.log(myCar.getCarInfo());
//  Union Types
function printId(id) {
    console.log("ID: ".concat(id));
}
printId(101);
printId("A102");
var emp1 = { id: 1, name: "Bob" };
var emp2 = { id: 2, name: "Alice", department: "HR" };
console.log(emp1, emp2);
// Generics
function getFirstElement(arr) {
    return arr[0];
}
var numbers = [1, 2, 3, 4];
var names = ["Alice", "Bob", "Charlie"];
console.log(getFirstElement(numbers));
console.log(getFirstElement(names));
