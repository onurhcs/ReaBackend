using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CommentProfileDto
    {
        public int Id { get; set; }
        public string CommentHeader { get; set; } = default!;

        public int User_Id { get; set; }
        public string CommentText { get; set; } = default!;
        public int StarRating { get; set; } = default!;
        public int Taste { get; set; }
        public int Follower { get; set; }


    }
}
