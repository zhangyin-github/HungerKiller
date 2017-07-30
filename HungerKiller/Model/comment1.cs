using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    /// <summary>
    /// 页面间传值试验
    /// </summary>
   
    public class details
    {
        public int dish_Name { get; set; }
        public string dish_Picture { get; set; }
        public string dish_Score { get; set; }
        public string dish_Classification { get; set; }
        public string dish_Taste { get; set; }
        public string dish_Ingredients { get; set; }
    }
    public class Comment
    {
        public string  User_Id { get; set; }
        public string User_comments { get; set; }
        public int Praise { get; set; }
        public string Data_Time { get; set; }
    }
    public class Comment_Manager
    {
        public static List<Comment> Get_Comment()
        {
            var Comment = new List<Comment>();
            int z = informationforcomment.getinstance().getcomments().Count();
            while (z > 0)
            {
             Comment.Add(new Comment(){User_Id = informationforcomment.getinstance().getcomments()[z-1].usersd,User_comments =informationforcomment.getinstance().getcomments()[z-1].concent, Praise = 10, Data_Time = informationforcomment.getinstance().getcomments()[z-1].datess+informationforcomment.getinstance().getcomments()[z-1].timess});
                z--;
            }
                return Comment;
         }
    }
}
