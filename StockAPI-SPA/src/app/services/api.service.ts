import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable, of } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class ApiService {
  apiURL = environment.apiUrl;

  constructor(private httpClient: HttpClient) {}

  public GetStockBySymbol(symbols: string) {
    return this.httpClient.get<any[]>(`${this.apiURL}/api/Stocks/${symbols}`).pipe(map(response => {
      return response;
    }));
  }

  public PostSymbolToAPI(symbols: string) : Observable<any> {

    let headers = new HttpHeaders().set('Accept', 'application/json, text/plain, */*');

    const body = {
      symbols
    }

    return this.httpClient.post(`${this.apiURL}/api/Stocks`, body, { headers: headers }).pipe(map(response => {
      return response;
    },
    catchError(err => of([]))));
  }
}
