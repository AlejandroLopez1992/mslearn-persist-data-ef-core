﻿using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Models;
using ContosoPizza.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CouponController : ControllerBase
    {
        PromotionsContext _context;

        public CouponController(PromotionsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Coupon>Get()
        {
            return _context.Coupons
                .AsNoTracking()
                .ToList();
        }
    }
}
