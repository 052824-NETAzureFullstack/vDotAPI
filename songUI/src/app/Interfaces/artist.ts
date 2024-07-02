import { Album } from "./album"
import { Songs } from "./songs"

export interface Artist {
    id: number;
    name: string;
    discography: [];
    songs: []
}
/*
    "collectionName": [ "val1", "val2" ],
    "objectName": {
        "key": value,
        "key2": value
    }




/*artist: {
      "id": 3,
      "name": "Gorillaz",
      "songs": [
        null
      ],
      "discography": []
    }, */
