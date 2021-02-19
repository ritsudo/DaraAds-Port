﻿using System.Collections.Generic;
using System.Linq;

namespace DaraAds.Application.Services.Abuse.Contracts
{
    public static class GetAbusePages
    {
        public sealed class Request
        {
            public int Offset { get; set; } = 0;
            public int Limit { get; set; } = 10;
        }

        public sealed class Response
        {
            public sealed class Item
            {
                public int Id { get; set; }
                public int AuthorId { get; set; }
                public int AbuseAdvId { get; set; }
                public int Priority { get; set; }
                public string AbuseText { get; set; }
            }

            public int Total { get; set; }
            public int Offset { get; set; }
            public int Limit { get; set; }

            public IEnumerable<Item> Items { get; set; } = Enumerable.Empty<Item>();
        }
    }
}