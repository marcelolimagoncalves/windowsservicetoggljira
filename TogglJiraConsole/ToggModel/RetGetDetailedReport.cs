﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglJiraConsole.ToggModel
{
    public class RetGetDetailedReport
    {
        public RetGetDetailedReport()
        {
            
        }

        public bool bError { get; set; }
        public List<Datum> lDatum { get; set; }
    }
}
