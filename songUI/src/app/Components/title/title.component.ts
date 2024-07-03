import { CommonModule, NgIf, AsyncPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Inject } from '@angular/core';
import { Songs } from '../../Interfaces/songs';
import { TitleService } from '../../Services/title.service';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-title',
  standalone: true,
  imports: [ CommonModule, NgIf, AsyncPipe ],
  templateUrl: './title.component.html',
  styleUrl: './title.component.css'
})

export class TitleComponent {
  currentTitle$!: Observable<Songs>;
  songId!: number;

  constructor(private titleService: TitleService, private route: ActivatedRoute) {
    this.songId = parseInt(this.route.snapshot.params['id'], 10);
    console.log(this.songId);

    this.currentTitle$ = this.titleService.GetSongById(this.songId);
  }

  ngOnInit(): void{

  }
}
