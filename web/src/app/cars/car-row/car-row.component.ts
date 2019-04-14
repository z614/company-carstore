import { Component, OnInit, Input } from '@angular/core';
import { Car } from '../car'

@Component({
  selector: 'app-car-row',
  templateUrl: './car-row.component.html',
  styleUrls: ['./car-row.component.css']
})
export class CarRowComponent implements OnInit {

  @Input() car: any;

  ngOnInit() {
  }

}
