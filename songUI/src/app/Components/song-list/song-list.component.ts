import { Component, inject } from '@angular/core';
import { TitleService } from '../../Services/title.service';
import { Songs } from '../../Interfaces/songs';
import { NgFor } from '@angular/common';
import { Observable } from 'rxjs';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-song-list',
  standalone: true,
  imports: [RouterModule],
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

  deleteSong(song: Songs) {
    // this.songService.Delete(id).subscribe( result => {
    //   console.log(result);
    // });
    // this.songService.GetSongs().subscribe( x => this.songList = x);

    let result = this.songService.Delete(song.id).subscribe( result => {
      console.log(result);
    });

    if (result) {
      this.songList.splice(this.songList.indexOf(song),1);
    }
  }
}
