import { Component, OnInit } from '@angular/core';
import { Car } from '../car';
import { CarsService } from '../cars.service';

@Component({
  selector: 'app-cars',
  templateUrl: './cars.component.html',
  styleUrls: ['./cars.component.css']
})
export class CarsComponent implements OnInit {

  cars: Car[];

  constructor(private CarsService: CarsService) { }

  ngOnInit() {
    this.getCars();
  }

  getCars() {
    this.CarsService.getCars().subscribe(cars => (this.cars = cars));
  }

}
