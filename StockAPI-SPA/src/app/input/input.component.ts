import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { StockData } from '../models/StockData';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-user-profile',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.scss']
})
export class InputComponent implements OnInit {
  stockData: StockData;

  constructor(private apiService: ApiService, private router: Router, private spinner: NgxSpinnerService) { }

  ngOnInit() {
  }

  postData(companyName: string) {
    this.spinner.show();
    this.apiService.PostSymbolToAPI(companyName).subscribe(response => {
    this.router.navigate(['/dashboard'], {queryParams: {Symbol: companyName}});
    console.log(response);

    setTimeout(() => {
      this.spinner.hide();
    }, 5000);
    });
  }
}
