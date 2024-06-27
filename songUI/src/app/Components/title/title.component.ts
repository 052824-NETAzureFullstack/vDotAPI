import { CommonModule, NgIf } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Inject } from '@angular/core';
import { Songs } from '../../Interfaces/songs';
import { TitleService } from '../../Services/title.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-title',
  standalone: true,
  imports: [ CommonModule, NgIf ],
  templateUrl: './title.component.html',
  styleUrl: './title.component.css'
})
export class TitleComponent {
  currentTitle$!: Observable<Songs>;

  constructor(private titleService: TitleService) { }

  ngOnInit(): void{
    this.currentTitle$ = this.titleService.GetSongById(0);
  }
}
