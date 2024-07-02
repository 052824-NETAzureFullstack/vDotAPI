import { Album } from "./album"
import { Songs } from "./songs"

export interface Artist {
    artistId: number;
    name: string;
    discography: Album;
    tracklist: Songs
}
