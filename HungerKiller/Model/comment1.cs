using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{

    public class Comment
    {
        public int User_Id { get; set; }
        public string Profile_Picture { get; set; }
        public string User_comments { get; set; }
        public int Praise { get; set; }
        public string Data_Time { get; set; }
    }
    public class Comment_Manager
    {
        public static List<Comment> Get_Comment()
        {
            var Comment = new List<Comment>();

            Comment.Add(new Comment() { User_Id = '1', Profile_Picture = "Assets/1.jpg", User_comments = "挺好吃的", Praise = 10, Data_Time = "2017.05.27 12:56" });
            Comment.Add(new Comment() { User_Id = '2', Profile_Picture = "Assets/1.jpg", User_comments = "挺好吃的", Praise = 5, Data_Time = "2017.05.27 12:56" });
            Comment.Add(new Comment() { User_Id = '3', Profile_Picture = "Assets/1.jpg", User_comments = "挺好吃的", Praise = 4, Data_Time = "2017.05.27 12:56" });
            Comment.Add(new Comment() { User_Id = '4', Profile_Picture = "Assets/1.jpg", User_comments = "挺好吃的", Praise = 40, Data_Time = "2017.05.27 12:56" });
            Comment.Add(new Comment() { User_Id = '5', Profile_Picture = "Assets/1.jpg", User_comments = "挺好吃的", Praise = 200, Data_Time = "2017.05.27 12:56" });
            Comment.Add(new Comment() { User_Id = '6', Profile_Picture = "Assets/1.jpg", User_comments = "挺好吃的", Praise = 20, Data_Time = "2017.05.27 12:56" });
            Comment.Add(new Comment() { User_Id = '7', Profile_Picture = "Assets/1.jpg", User_comments = "挺好吃的", Praise = 10, Data_Time = "2017.05.27 12:56" });
            Comment.Add(new Comment() { User_Id = '8', Profile_Picture = "Assets/1.jpg", User_comments = "挺好吃的", Praise = 50, Data_Time = "2017.05.27 12:56" });
            return Comment;
         }
    }
}
