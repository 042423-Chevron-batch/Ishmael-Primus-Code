import { Component, OnInit } from '@angular/core';
import { BuyerService } from '../services/buyer.service'

@Component({
  selector: 'app-buyer-auth',
  templateUrl: './buyer-auth.component.html',
  styleUrls: ['./buyer-auth.component.css']
})

export class BuyerAuthComponent implements OnInit {
  constructor(private buyer: BuyerService) { }

  ngOnInit(): void { }

  userSignUp(data: object): void {
    console.warn(data);
    this.buyer.userSignUp(data).then(result => {
      console.warn("result", result);
    });
  }
}
