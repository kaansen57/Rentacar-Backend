﻿using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private IBrandManager _brandManager;

        public BrandController(IBrandManager brandManager)
        {
            _brandManager = brandManager;
        }

        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandManager.Add(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandManager.Delete(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandManager.Update(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandManager.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _brandManager.GetBrand(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
