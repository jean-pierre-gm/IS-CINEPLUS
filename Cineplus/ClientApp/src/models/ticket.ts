import {Seat} from "./seat";
import {Reproduction} from "./reproduction";
import {User} from "./user";
import {DateDiscount} from "./dateDiscount";
import {PersonalDiscount} from "./personalDiscount";

export class Ticket {
  seatId: number;
  seat: Seat;
  reproductionId: number;
  reproduction : Reproduction;
  userId: string;
  user: User;
  price: number;
  pointsPrice: number;
  dateDiscount: DateDiscount;
  personalDiscounts: PersonalDiscount[];
  orderId:string;
  reserveTime:Date;
}
