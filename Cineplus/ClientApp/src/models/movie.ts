import {Genre} from "./genre";
import {Actor} from "./actor";

export class Movie {
  id : number = 0;
  score: number;
  duration: number;
  movieName: string;
  director: string;
  genre: Genre;
  description: string;
  imageUrl: string;
  actors: Actor[];
  country: string;
}
