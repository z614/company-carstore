import { Component, OnInit } from '@angular/core';
import { Car } from '../car';

@Component({
  selector: 'app-cars',
  templateUrl: './cars.component.html',
  styleUrls: ['./cars.component.css']
})
export class CarsComponent implements OnInit {

  cars: Car[] = [
  {
    id: 1,
    make: 'Jeep',
    model: 'Compass',
    year: 2015,
    numofmiles: 85642,
    numofseats: 5,
    category: 'SUV' 
  },
  {
    id: 2,
    make: 'Ford',
    model: 'Focus',
    year: 2016,
    numofmiles: 76589,
    numofseats: 5,
    category: 'Sedan'
  }];

  constructor() { }

  ngOnInit() {
  }

}
