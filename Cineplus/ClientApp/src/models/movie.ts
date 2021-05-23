import {Genre} from "./genre";

export class Movie {
  id : number = 0;
  score: number;
  duration: number;
  movieName: string;
  director: string;
  genre: Genre;
}