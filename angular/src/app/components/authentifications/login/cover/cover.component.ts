import { Component } from '@angular/core';
import { AuthService } from '@abp/ng.core';


@Component({
  selector: 'app-cover',
  imports: [],
  templateUrl: './cover.component.html',
  styleUrl: './cover.component.css'
})
export class CoverComponent {
  //constructor(private authService: AuthService) {}

  // login() {
  //   this.authService.login().subscribe({
  //     next: (result) => {
  //       console.log('Login successful', result);
  //     },
  //     error: (err) => {
  //       console.error('Login failed', err);
  //     },
  //   });
  // }
}
