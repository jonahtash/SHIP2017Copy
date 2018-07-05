using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHIPSite
{
    public class Row : IComparable
    {
        public string id {get;set;}
        public string title { get; set;}
        public string snippet { get; set; }
        public string abs { get; set; }

        public Row(string id, string title, string snippet, string abs)
        {
            this.id = id;
            this.title = title;
            this.snippet = snippet;
            this.abs = abs;
        }

        public int CompareTo(object obj)
        {
            return id.CompareTo(obj);
        }
    }
}