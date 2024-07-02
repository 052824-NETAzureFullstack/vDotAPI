import { Album } from "./album";
import { Artist } from "./artist";

export interface Songs {
    id: number;
    songName: string;
    genre: string;
    tempo: number;
    artist: Artist;
    album: Album
}
