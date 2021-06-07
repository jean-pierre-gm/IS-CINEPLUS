import {HttpClient, HttpParams} from "@angular/common/http";
import {Pagination} from "./pagination";
import {DataSourceConf} from "./dataSourceConf";

export class CineplusDataSource<T> {

  public currentPagination: Pagination<T> = new Pagination<T>()
  get result (): T[] { return this.currentPagination.result }
  get hasNext (): boolean { return this.currentPagination.currentPage < this.currentPagination.totalPages }
  get hasPrevious (): boolean { return this.currentPagination.currentPage > 1 }
  get totalPages (): number { return this.currentPagination.totalPages }

  constructor(private httpClient: HttpClient,
              private conf: DataSourceConf,
              pagination?: Pagination<T>,
              public httpParams: HttpParams = new HttpParams()) {
    if (!conf.endPoint || conf.endPoint == ''){
      throw new Error('Endpoint can not be empty.')
    }

    this.currentPagination.currentPage = 1;
    this.currentPagination.pageSize = (pagination && pagination.pageSize) ? pagination.pageSize : 10;
    this.currentPagination.orderByDesc = false;

    this.refresh();
  }

  refresh() {
    this.redoParams();
    console.log('httpParams', this.httpParams.toString())
    return this.httpClient.get<Pagination<T>>(this.conf.endPoint + '?' + this.httpParams.toString()).subscribe(result => {
      this.currentPagination = result;
    }, error => console.log(error));
  }

  setPage(page: number) {
    if (page < 1 || page > this.currentPagination.totalPages) {
      throw new Error('Page out of bounds')
    }
    this.currentPagination.currentPage = page;
    return this.refresh();
  }

  nextPage() {
    let page = this.currentPagination.currentPage + 1
    return this.setPage(page);
  }

  previousPage() {
    let page = this.currentPagination.currentPage - 1
    return this.setPage(page);
  }

  orderBy(value: string, reverse = false) {
    this.currentPagination.orderBy = value;
    this.currentPagination.orderByDesc = reverse;
    return this.refresh();
  }

  filter(filterBy: string, filterString: string) {
    this.currentPagination.filterBy = filterBy;
    this.currentPagination.filterString = filterString;
    return this.refresh();
  }

  undoFilters() {
    this.currentPagination.filterBy = null;
    this.currentPagination.filterString = null;
    return this.refresh();
  }

  undoOrder() {
    this.currentPagination.orderBy = null;
    return this.refresh()
  }

  invertOrder() {
    this.currentPagination.orderByDesc = !this.currentPagination.orderByDesc;
    return this.refresh();
  }

  noOrderRefresh() {
    this.currentPagination.orderBy = undefined
    return this.refresh()
  }

  redoParams() {
    this.httpParams = this.httpParams.set(this.conf.pageSize, this.currentPagination.pageSize.toString());
    this.httpParams = this.httpParams.set(this.conf.currentPage, this.currentPagination.currentPage.toString());
    if (this.currentPagination.orderBy) {
      this.httpParams = this.httpParams.set(this.conf.orderByDescendingField, String(this.currentPagination.orderByDesc));
      this.httpParams = this.httpParams.set(this.conf.orderByField, this.currentPagination.orderBy);
    } else {
      this.httpParams = this.httpParams.delete(this.conf.orderByField);
      this.httpParams = this.httpParams.delete(this.conf.orderByDescendingField);
    }
    if (this.currentPagination.filterBy) {
      this.httpParams = this.httpParams.set(this.conf.filterByField, String(this.currentPagination.filterBy))
      this.httpParams = this.httpParams.set(this.conf.filterStringField, String(this.currentPagination.filterString))
    } else {
      this.httpParams = this.httpParams.delete(this.conf.filterByField);
      this.httpParams = this.httpParams.delete(this.conf.filterStringField);
    }
  }

}
