﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglJiraConsole
{
    public class AvatarUrls
    {
        public string __invalid_name__16x16 { get; set; }
        public string __invalid_name__24x24 { get; set; }
        public string __invalid_name__32x32 { get; set; }
        public string __invalid_name__48x48 { get; set; }
    }

    public class Author
    {
        public string self { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
    }

    public class AvatarUrls2
    {
        public string __invalid_name__16x16 { get; set; }
        public string __invalid_name__24x24 { get; set; }
        public string __invalid_name__32x32 { get; set; }
        public string __invalid_name__48x48 { get; set; }
    }

    public class UpdateAuthor
    {
        public string self { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls2 avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
    }

    public class WorklogPost
    {
        public string self { get; set; }
        public Author author { get; set; }
        public UpdateAuthor updateAuthor { get; set; }
        public string comment { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public DateTime started { get; set; }
        public string timeSpent { get; set; }
        public int timeSpentSeconds { get; set; }
        public string id { get; set; }
    }
}
