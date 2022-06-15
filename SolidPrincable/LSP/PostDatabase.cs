using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincable.LSP
{
   public class PostDatabase
    {
        public string Add(string post)
        {
            return "Orignal post :" + post;
        }

        public string AddTagPost(string post)
        {
            return "TagPost post :" + post;
        }

        public string AddMentionPost(string post)
        {
            return "Mention post :" + post;
        }



    }
}
