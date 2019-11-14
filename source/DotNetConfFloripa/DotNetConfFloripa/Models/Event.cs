using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetConfFloripa.Models
{
    public class Event
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public static List<Event> Events = new List<Event>
        {
            new Event
            {
                Name = "Event 1",
                ImageUrl = "https://www.dotnetconf.net/img/dotNETConf_banners_facebook_eventinfo.png",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Event
            {
                Name = "Event 2",
                ImageUrl = "https://www.dotnetconf.net/img/dotNETConf_banners_facebook_eventinfo.png",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Event
            {
                Name = "Event 3",
                ImageUrl = "https://www.dotnetconf.net/img/dotNETConf_banners_facebook_eventinfo.png",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Event
            {
                Name = "Event 4",
                ImageUrl = "https://www.dotnetconf.net/img/dotNETConf_banners_facebook_eventinfo.png",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Event
            {
                Name = "Event 5",
                ImageUrl = "https://www.dotnetconf.net/img/dotNETConf_banners_facebook_eventinfo.png",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Event
            {
                Name = "Event 6",
                ImageUrl = "https://www.dotnetconf.net/img/dotNETConf_banners_facebook_eventinfo.png",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Event
            {
                Name = "Event 7",
                ImageUrl = "https://www.dotnetconf.net/img/dotNETConf_banners_facebook_eventinfo.png",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            }
        };
    }
}
