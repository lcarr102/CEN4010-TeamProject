using System;
using AspNetCoreDemoApp.Binders;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemoApp.Models
{
    [FirestoreData]
    public class Book : IFirestoreDocumentModel
    {
        public string Id { get; set; }

        [FirestoreProperty(name: "title")]
        public string Title { get; set; }

        [FirestoreProperty(name: "author")]
        public string Author { get; set; }

        [FirestoreProperty(name: "price")]
        public string Price { get; set; }

        [FirestoreProperty(name: "rating")]
        public string Rating { get; set; }

        [FirestoreProperty(name: "releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [FirestoreProperty(name: "genre")]
        public string Genre { get; set; }

        [FirestoreProperty(name: "topSeller")]
        public bool TopSeller { get; set; }

        [FirestoreProperty(name: "imageUrl")]
        public string ImageUrl { get; set; }
    }
}