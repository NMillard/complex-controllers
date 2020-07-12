using System;

namespace ComplexControllers.Domain {
    public class Article {
        private string id;
        
        public Article() {
            id = Guid.NewGuid().ToString();
        }
    }
}