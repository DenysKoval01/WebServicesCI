﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServicesCI.Constants
{
    public static class HttpHeaders
    {
        public static class Name
        {
            public static string ContentType => "Content-Type";

            public static string Accept => "Accept";

            public static string Cookie => "Cookie";
        }

        public static class Value
        {
            public static string ApplicationJson => "application/json";
        }
    }
}
