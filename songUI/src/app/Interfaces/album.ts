import { Artist } from "./artist"
import { Songs } from "./songs"

export interface Album {
    id: number;
    albumName: string;
    composers: [];
    tracklist: []
}

/*"album": {
      "id": 3,
      "albumName": "Gorillaz",
      "trackList": [
        null
      ],
      "composers": []
    }
  } */
