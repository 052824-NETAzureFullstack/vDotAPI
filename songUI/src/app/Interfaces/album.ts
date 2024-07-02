import { Artist } from "./artist"
import { Songs } from "./songs"

export interface Album {
    albumId: number;
    albumName: string;
    artist: Artist;
    tracklist: Songs
}
