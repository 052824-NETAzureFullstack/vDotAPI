import { Routes } from '@angular/router';
import { TitleComponent } from './Components/title/title.component';
import { SongListComponent } from './Components/song-list/song-list.component';
import { AppComponent } from './app.component';
import { AddSongsComponent } from './Components/add-songs/add-songs.component';

export const routes: Routes = [
    {
        path:'song',
        component: SongListComponent
    },
    {
        path:'song/:id',
        component: TitleComponent
    },
    {
        path:'songadd',
        component: AddSongsComponent
    }
];
