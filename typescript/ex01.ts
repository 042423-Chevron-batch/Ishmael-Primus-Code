
/*
For this exercise, create an interface. The interface should have at least 
5 properties and at at least one optional property. Create an array and fill it with at
least 3 objects which fit the interface you created. Be as specific as possible when 
declaring variables (Give all variables a type and don't use the "any" keyword)
*/

// Define the interface
interface Person {
    name: string;
    age: number;
    height: number;
    weight: number;
    hairColor?: string;
};

// Create an array 
const people: Person[] = [];

// Create objects that conform to the interface and push them into the array
const person1: Person = {
    name: 'Ishmael',
    age: 25,
    height: 5.5,
    weight: 150,
    hairColor: 'black'
};

const person2: Person = {
  name: "Brian",
  age: 25,
  height: 6.5,
  weight: 180,
  hairColor: "black",
};

const person3: Person = {
  name: "Kedar",
  age: 30,
  height: 5.5,
  weight: 190,
  hairColor: "black",
};

// Push the objects into the array
people.push(person1, person2, person3);