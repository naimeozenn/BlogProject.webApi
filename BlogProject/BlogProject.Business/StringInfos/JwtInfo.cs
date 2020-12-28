using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Business.StringInfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:54694";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "naimenaimenaime1";
        public const double Expires = 40;
    }
}
