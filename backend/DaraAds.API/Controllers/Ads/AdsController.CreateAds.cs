﻿using DaraAds.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaraAds.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DaraAds.API.Controllers.Ads
{
    
    public partial class AdsController : ControllerBase
    {
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostTodoItem(Advertisement newAdvertisement)
        {
            if (newAdvertisement == null)
            {
                return BadRequest();
            }
            _context.Advertisements.Add(newAdvertisement);
            await _context.SaveChangesAsync();

            
            return Created($"api/Ads/{newAdvertisement.Id}", newAdvertisement);
        }

    }
}