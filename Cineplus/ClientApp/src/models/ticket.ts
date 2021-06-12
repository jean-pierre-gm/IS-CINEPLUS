import {Seat} from "./seat";
import {Reproduction} from "./reproduction";
import {User} from "./user";

export class Ticket {
  seat: Seat;
  pointsPrice: number;
  price: number;
  user: User;
  reproductionId: number;
  reproduction: Reproduction;
}
