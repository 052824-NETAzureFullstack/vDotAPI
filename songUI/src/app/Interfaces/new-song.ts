import { NewAlbum } from "./new-album";
import { NewArtist } from "./new-artist";

export interface NewSong {
    songName: string;
    genre: string;
    tempo: number;
    artist: NewArtist;
    album: NewAlbum;
}
