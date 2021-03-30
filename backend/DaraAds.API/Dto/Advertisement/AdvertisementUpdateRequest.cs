using System.ComponentModel.DataAnnotations;

namespace DaraAds.API.Dto.Advertisement
{
    public sealed class AdvertisementUpdateRequest
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        
        public string Cover { get; set; }
        
        public int CategoryId { get; set; }
    }
}