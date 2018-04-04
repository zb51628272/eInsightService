using System;
using System.Collections.Generic;
using System.Text;

namespace ESB_Classes.Events
{
    public class ErrorThrown
    {
        public string MessageName { get; set; }
        public string ErrorDesc { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
