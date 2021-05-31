using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class GeneralDTO
    {
        public PostDTO PostDetail { get; set; }
        public List<PostDTO> CategoryPostList { get; set; }
        public string CategoryName { get; set; }
        public string SearchText { get; set; }
        public string SearchText1 { get; set; }
        public string CategoryNameS { get; set; }
        public string CategoryNameI { get; set; }
        public string SearchText2 { get; set; }


    }
}
