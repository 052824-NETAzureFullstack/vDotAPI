import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { NewSong } from '../../Interfaces/new-song';
import { NewAlbum } from '../../Interfaces/new-album';
import { NewArtist } from '../../Interfaces/new-artist';
import { TitleService } from '../../Services/title.service';

@Component({
  selector: 'app-add-songs',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-songs.component.html',
  styleUrl: './add-songs.component.css'
})
export class AddSongsComponent {
  song: NewSong = {
    songName: '',
    genre: '',
    tempo: 0,
    artist: {
      name : '',
      songs : [],
      discography : []
    },
    album : {
      albumName : '',
      trackList : [],
      composers : []
    },
  }

  constructor(private titleService: TitleService) {}

  addSong() {
    console.log(this.song);
    this.titleService.AddNewSong(this.song).subscribe( result => {
      console.log(result)
    });
  }
}

/*{
    "id": 7,
    "songName": "The Real Folk Blues",
    "genre": "Jazz",
    "tempo": 90,
    "artist": {
      "id": 5,
      "name": "The Seatbelts",
      "songs": [
        null
      ],
      "discography": []
    },
    "album": {
      "id": 5,
      "albumName": "Cowboy Bebop Vitaminless",
      "trackList": [
        null
      ],
      "composers": []
    }
  }
*/