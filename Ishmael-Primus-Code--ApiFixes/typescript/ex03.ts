/* Add a type to the following variables to eliminate compilation errors
Do NOT use the "any" type
Do NOT remove any code
*/

let year: string | number = "1999";
year = 1999;

let arr: (number | string)[] = [3];
arr.push("cat");


interface Plumber {
  name: string;
  color: string;
  power: string;
}

let Plumber = "Mario";
let plumber: Plumber = {
  name: "Mario",
  color: "red",
  power: "mushroom",
};
