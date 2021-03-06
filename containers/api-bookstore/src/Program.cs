﻿using Framework.Web.Common;
using System.Threading.Tasks;

namespace Bookstore.Api
{
    public class Program
    {
        protected Program()
        {
        }
        public static async Task<int> Main(string[] args)
        {
            return await WebHostBootstrap.RunAsync<Startup>("http://*:9012");
        }
    }
}
