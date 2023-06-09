/*
    For each of the following variable declarations, add a type and make sure the program still compiles
    Do NOT use the "any" type.
    Create no more than 2 interfaces
    Do not delete any code.
*/

let age: number = 4;
let fruit: string = "banana";
let hungry: boolean = true;

let friends = ["Eren", "Armin", "Mikasa", "Jean", "Connie", "Sasha"];

// Define the interface for movies
interface movie {
    title: string;
    year: number;
    directors: string[];
    basedOn?: string;
};

// Define the interface for friends
interface friends {
    name: string;
    favoriteMovie: string;
    title: string;
    year: number;
    directors: string[];

};

let movie1 = {
  title: "Jurassic Park",
  year: 1993,
  directors: ["Spielberg"],
  basedOn: "Jurassic Park by Michael Crichton",
};

let movie2 = {
  title: "Everything Everywhere All At Once",
  year: 2022,
  directors: ["Kwan", "Scheinart"],
};

let person = {
  name: "Rick Grimes",
  favoriteMovie: {
    title: "The Shawshank Redemption",
    year: 1994,
    directors: ["Darabont"],
  },
};

let movies = [movie1, movie2];
