﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wchl.WMBlog.Model.VeiwModels
{
    public class LoginInfoViewModels
    {
        public string uLoginName { get; set; }

        public string uLoginPwd { get; set; }

        public string VCode { get; set; }

        public bool IsMember { get; set; }
    }
}
