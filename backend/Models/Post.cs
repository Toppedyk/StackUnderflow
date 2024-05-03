using System;
namespace backend.Models
{
    public class Post
    {
        public string body;
        public string title;
        public Guid postID;
        public string creatorId;
        public Comment[] comments;
        public string[] likes;
    }
}