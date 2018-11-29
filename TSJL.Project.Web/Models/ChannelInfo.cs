using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSJL.Project.Web.Models
{
    public class ChannelInfo
    {
        public virtual int ID { get; set; }

        public virtual string ChannelStyle { get; set; }

        public virtual string ChannelCode { get; set; }
        public virtual string CnName { get; set; }
        public virtual string EnName { get; set; }

        public virtual string Status { get; set; }
    }
}