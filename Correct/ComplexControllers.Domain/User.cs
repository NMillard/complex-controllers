using System;
using System.Collections.Generic;

namespace ComplexControllers.Domain {
    public class User {
        private string id;
        private readonly List<Article> articles;
        
        public User(string username) {
            Username = username;
            id = Guid.NewGuid().ToString();
            articles = new List<Article>();
        }

        public string Username { get; private set; }
        public IReadOnlyList<Article> Articles => articles;
    }
}