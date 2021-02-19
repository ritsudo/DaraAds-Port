﻿using DaraAds.Application.Services.Advertisement.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using DaraAds.Application.Services.Advertisement.Contracts;
using System.ComponentModel.DataAnnotations;

namespace DaraAds.API.Controllers.Advertisement
{
    public partial class AdvertisementController : ControllerBase
    {
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            CancellationToken cancellationToken,
            [FromServices] IAdvertisementService service,
            [FromRoute] int id,
            AdvertisementUpdateRequest request)
        {
            var response = await service.Update(new Update.Request
            {
                Id = id,
                Title = request.Title,
                Description = request.Description,
                Price = request.Price,
                Cover = request.Cover
            }, cancellationToken);

            return Ok(response.Id);

        }
    }

    public sealed class AdvertisementUpdateRequest
    {

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Description { get; set; }

        [Required]
        [Range(0, 100_000_000_000)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(300)]
        public string Cover { get; set; }
    }
}