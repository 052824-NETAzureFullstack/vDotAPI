import { Injectable, inject } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Songs } from '../Interfaces/songs';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { NewSong } from '../Interfaces/new-song';

@Injectable({
  providedIn: 'root'
})
export class TitleService {

  URL: string = 'http://localhost:5125/api/song';
  http = inject(HttpClient);

  constructor() { }

  // HTTP requests below
  GetSongById(songId: number): Observable<Songs> {
    return this.http.get<Songs>(`${this.URL}/${songId}`);
  }

  GetSongs(): Observable<Songs[]> {
    // var response = this.http.get<Songs[]>(this.URL);
    // response.subscribe( result => {console.log(result)});
    return this.http.get<Songs[]>(this.URL);
  }

  AddNewSong(newSong: NewSong) {
    return this.http.post<any>(this.URL, newSong);
  }

  Delete(deleteSong: number) {
    return this.http.delete<any>(this.URL + '/' + deleteSong);
  }
}
