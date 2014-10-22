using System;

namespace SchoolSpace
{
    public class Class : School, ICommentable
    {
        //.tor
        public Class(string name) : base(name)
        {
        }

        //implementation of interface
        public string Comment  { get; set; }
    }
}
