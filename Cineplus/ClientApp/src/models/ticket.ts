import {Seat} from "./seat";
import {Reproduction} from "./reproduction";

export class Ticket {
  seat: Seat;
  price: number;
  reproductionId: number;
  reproduction: Reproduction;
}
