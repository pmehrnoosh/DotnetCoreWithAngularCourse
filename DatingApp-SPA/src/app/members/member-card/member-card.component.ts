import { Component, OnInit, Input } from '@angular/core';
import { User } from 'src/app/_model/User';

@Component({
  selector: 'app-member-card',
  templateUrl: './member-card.component.html',
  styleUrls: ['./member-card.component.css']
})
export class MemberCardComponent implements OnInit {
@Input() User: User;
  constructor() { }

  ngOnInit() {
  }

}
