﻿namespace DaraAds.Application.Services.Advertisement.Contracts
{
    public static class Create
    {
        public sealed class Request
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string Cover { get; set; }
            
        }

        public sealed class Response
        {
            public int Id { get; set; }
        }
    }
}