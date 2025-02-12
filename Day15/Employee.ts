class Employee {
    public age: number;
    public name: string;
    constructor(age: number, name: string) {
        this.age = age;
        this.name = name;
    }
}


//creating object 
var emp = new Employee(12, "nitin");

let emps: Employee[] = [new Employee(12, "akash"),
new Employee(23, "vikash")
];


//map
emps.map((e) => (
    console.log(e.name),
    console.log(e.age)
))


//foreach
emps.forEach((e) => {
    console.log(e.age)
    console.log(e.name)
})