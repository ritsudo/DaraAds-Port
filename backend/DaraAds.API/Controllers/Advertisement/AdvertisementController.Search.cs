﻿using DaraAds.Application.Services.Advertisement.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using DaraAds.API.Dto.Advertisement;

namespace DaraAds.API.Controllers.Advertisement
{
    public partial class AdvertisementController : ControllerBase
    {
        /// <summary>
        /// Поиск объявления
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery]SearchRequest request, CancellationToken cancellationToken)
        {
            var result = await _service.Search(new Search.Request
            {
                KeyWord = request.KeyWord,
                Limit = request.Limit,
                Offset = request.Offset
            }, cancellationToken);

            return Ok(result);
        }
    }
}
