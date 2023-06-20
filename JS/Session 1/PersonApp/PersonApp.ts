// import { Gender } from "./enum/enum"; 
// console.log(Gender) 
// var type = Gender 
 
class MyException extends Error {
  constructor(message: string) {
    super(message);
  }
}


enum gender { 
    male = "male", 
    female = "female", 
   } 
    
   type person = { 
    age: number; 
    id: number; 
    gender: gender; 
    name : string;
    height : number;
    weight : number;
    
   }; 
    
   class Person 
   { 
    age: number; 
    gender:gender; 
    id: number; 
    name : string;
    height : number;
    weight : number;
    
    
    constructor({age, gender, id, name, height, weight}:person) { 

     this.gender = gender; 
     this.id = id; 
     this.name = name;
     this.height = height;
     this.weight = weight;
    
     
        if (age > 0 && age < 100) {
          this.age = age;
        } else {
          throw new MyException("Invalid Age");
        }
      

    }
    
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
     
   
   get BMI(): number {
    return this.weight / (this.height * this.height);
  }
  
};
  try{
   const arr:person[] = []; 
   const arr1 = new Person({age:30, gender:gender.male, id:434, name : "Anurag", height:5, weight: 50}); 
   // const arr2 = new Person(121, gender.male, 434); 
    
    
   arr.push(arr1); 
   // arr.push(arr2); 
   printPersonDetails(arr);

  }
  catch (error) {
    console.log(error.message)
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
  

  function printPersonDetails(arr: any): void {
    arr.forEach((val: any) => {
      console.log(`Age is = ${val.age}, gender is = ${val.gender}, Id is = ${val.id}, 
      Name is = ${val.name}, Height is = ${val.height}, Weight is = ${val.weight}
      BMI is = ${val.BMI}`);
    });
  }