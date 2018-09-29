export class BookInterface {
    id: string;
    title: string;
    author: string;
    price: number;
    rating: number;
    releaseDate: Date;
    genre: string;
    topSeller: boolean;
}

export interface SelectableBook extends BookInterface {
    isSelected: boolean;
}