using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class ImagePosts:Posts
    {
        public string ImageURL { get; set; }

        public ImagePosts()
        {

        }

        public ImagePosts(string Title, string SentByUsername, string ImageURL, bool IsPublic)
        {
            this.ID = GetNextId();
            this.Title = Title;
            this.SentByUsername = SentByUsername;
            this.IsPublic = IsPublic;
            this.ImageURL = ImageURL;

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} ", this.ID, this.ImageURL, this.SentByUsername);
        }

    }
}
