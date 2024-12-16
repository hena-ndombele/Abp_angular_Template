import { Component } from '@angular/core';
import {RouterLinkActive, RouterModule} from '@angular/router';

@Component({
  selector: 'app-sidebar',
  imports: [
    RouterLinkActive,
    RouterModule,

  ],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent {

}
