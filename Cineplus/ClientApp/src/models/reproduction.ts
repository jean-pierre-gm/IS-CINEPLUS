import {Movie} from "./movie"
import {Theater} from "./theater";

export class Reproduction{
  id: number;
  movie: Movie;
  theaterId: number;
  theater: Theater;
  startTime: Date;
}
