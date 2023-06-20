// import { Gender } from "./enum/enum"; 
// console.log(Gender) 
// var type = Gender 
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var MyException = /** @class */ (function (_super) {
    __extends(MyException, _super);
    function MyException(message) {
        return _super.call(this, message) || this;
    }
    return MyException;
}(Error));
var gender;
(function (gender) {
    gender["male"] = "male";
    gender["female"] = "female";
})(gender || (gender = {}));
var Person = /** @class */ (function () {
    function Person(_a) {
        var age = _a.age, gender = _a.gender, id = _a.id, name = _a.name, height = _a.height, weight = _a.weight;
        this.gender = gender;
        this.id = id;
        this.name = name;
        this.height = height;
        this.weight = weight;
        if (age > 0 && age < 100) {
            this.age = age;
        }
        else {
            throw new MyException("Invalid Age");
        }
    }
    Object.defineProperty(Person.prototype, "BMI", {
        // get Gen() { 
        //  return this.gender; 
        // } 
        // get ID() { 
        //  return this.age ; 
        // } 
        // get Height() {
        //     return this.Height;
        // }
        // get Weight() {
        //     return this.Weight;
        // }
        get: function () {
            return this.weight / (this.height * this.height);
        },
        enumerable: false,
        configurable: true
    });
    return Person;
}());
;
try {
    var arr = [];
    var arr1 = new Person({ age: 30, gender: gender.male, id: 434, name: "Anurag", height: 5, weight: 50 });
    // const arr2 = new Person(121, gender.male, 434); 
    arr.push(arr1);
    // arr.push(arr2); 
    printPersonDetails(arr);
}
catch (error) {
    console.log(error.message);
}
// arr.push({ age: 12, id: 143, gender: gender.female }); 
// arr.push({ age: 13, id: 143, gender: gender.female }); 
// arr.push({ age: 14, id: 143, gender: gender.female }); 
// arr.push({ age: 15, id: 143, gender: gender.female }); 
// arr.push({ age: 15, id: 143, gender: gender.female }); 
//  arr.forEach((val: any) => { 
//   console.log(`Age is = ${val.age}, gender is = ${val.gender}, Id is = ${val.id}, Name is = ${val.name}, Height is = ${val.height}, Weight is = ${val.weight}
//   BMI is = ${val.BMI}`);
// });
function printPersonDetails(arr) {
    arr.forEach(function (val) {
        console.log("Age is = ".concat(val.age, ", gender is = ").concat(val.gender, ", Id is = ").concat(val.id, ", \n      Name is = ").concat(val.name, ", Height is = ").concat(val.height, ", Weight is = ").concat(val.weight, "\n      BMI is = ").concat(val.BMI));
    });
}
