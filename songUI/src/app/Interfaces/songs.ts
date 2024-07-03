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