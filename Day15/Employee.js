var Employee = /** @class */ (function () {
    function Employee(age, name) {
        this.age = age;
        this.name = name;
    }
    return Employee;
}());
//creating object 
var emp = new Employee(12, "nitin");
var emps = [new Employee(12, "akash"),
    new Employee(23, "vikash")
];
//map
emps.map(function (e) { return (console.log(e.name),
    console.log(e.age)); });
//foreach
emps.forEach(function (e) {
    console.log(e.age);
    console.log(e.name);
});
