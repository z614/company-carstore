import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Car } from './Car';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CarsService {
  private carsUri = 'http://company-api-gunauger.azurewebsites.net/api/cars';
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error('${operation} failed: ${error.message}');
      return of(result as T);
    };
  }

  constructor(private http: HttpClient) {}
 
  getCars(): Observable<Car[]> {
    return this.http.get<Car[]>(this.carsUri).pipe(
      tap(_ => console.log('fetched cars')),
      catchError(this.handleError<Car[]>('getCars', []))
    );
  }

}