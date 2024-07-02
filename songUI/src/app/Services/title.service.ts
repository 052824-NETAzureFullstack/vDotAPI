import { Injectable, inject } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Songs } from '../Interfaces/songs';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TitleService {

  URL: string = 'http://localhost:5125/api/song';
  http = inject(HttpClient);

  constructor() { }

  GetSongById(songId: number): Observable<Songs> {
    return this.http.get<Songs>(`${this.URL}/${songId}`);
  }
}
