using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;

namespace WebApplication1
{
    internal class CookieAuthenticationOption : CookieAuthenticationOptions
    {
        public object AuthenticationType { get; set; }
        public PathString LoginPath { get; set; }
    }
}