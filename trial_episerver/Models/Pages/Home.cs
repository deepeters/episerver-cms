using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace trial_episerver.Models.Pages
{
    [ContentType]
    public class Home : PageData
    {
        public virtual string Heading { get; set; }
        public virtual XhtmlString MainBody { get; set; }
    }
}