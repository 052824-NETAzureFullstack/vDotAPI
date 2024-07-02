import { Component, inject } from '@angular/core';
import { TitleService } from '../../Services/title.service';
import { Songs } from '../../Interfaces/songs';
import { NgFor } from '@angular/common';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-song-list',
  standalone: true,
  imports: [],
  templateUrl: './song-list.component.html',
  styleUrl: './song-list.component.css'
})
export class SongListComponent {
  private songService = inject(TitleService);

  songs$!: Observable<Songs[]>;
  public songList: Songs[] = [];

  ngOnInit(): void {
    this.songs$ = this.songService.GetSongs();
    this.songs$.subscribe( x => this.songList = x);
    // console.log(this.songList);
  }
}
