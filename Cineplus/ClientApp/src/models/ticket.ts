import {Seat} from "./seat";
import {Reproduction} from "./reproduction";
import {User} from "./user";

export class Ticket {
  orderId: string;
  seat: Seat;
  price: number;
  pointsPrice: number;
  user: User;
  reproductionId: number;
  reproduction: Reproduction;
}
