export class Pagination<T> {
  currentPage: number;
  pageSize: number;
  totalItems: number;
  orderBy: string;
  totalPages: number;
  orderByDesc: boolean;
  result: T[];
}
