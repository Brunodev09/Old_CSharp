using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Posts
    {
        protected int ID { get; set; }
        protected int currentId = 0;
        protected string Title { get; set; }
        protected string SentByUsername { get; set; }
        protected bool IsPublic { get; set; }  

        public Posts()
        {
            ID = 0;
            Title = "Default";
            SentByUsername = "Brunodev09";
            IsPublic = true;
        }
        public Posts(string Title, string SentByUsername, bool isPublic)
        {
            this.Title = Title;
            this.SentByUsername = SentByUsername;
            this.IsPublic = IsPublic;
        }

        public void Update(string Title, bool isPublic)
        {
            this.Title = Title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} ", this.ID, this.Title, this.SentByUsername);
        }

        protected int GetNextId()
        {
            return ++currentId;
        }

    }
}
