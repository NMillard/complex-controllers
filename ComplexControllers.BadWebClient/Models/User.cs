using System;
using System.Collections.Generic;

namespace ComplexControllers.BadWebClient.Models {
    public class User {
        private string id;
        private readonly List<Article> articles;
        
        public User(string username) {
            id = Guid.NewGuid().ToString();
            Username = username;
            articles = new List<Article>();
        }
        
        public string Username { get; private set; }
        public IReadOnlyList<Article> Articles => articles.AsReadOnly();
    }

    public class Article {
        private string id;

        public Article() {
            id = Guid.NewGuid().ToString();
        }

        public string Title { get; set; }
    }
}