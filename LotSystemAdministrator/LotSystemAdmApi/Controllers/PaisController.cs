using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LotSystemAdmDomain.Entities;
using LotSystemAdmDomain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LotSystemAdmApi.Controllers
{
    [Route("v1/pais")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly IPaisService _paisService;

        public PaisController(IPaisService paisService)
        {
            _paisService = paisService;
        }

        [HttpPost]
        public IActionResult Register([FromBody] Pais pais)
        {
            try
            {
                _paisService.Insert(pais);

                return Ok(pais.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Pais pais)
        {
            try
            {
                _paisService.Update(pais);

                return Ok(pais);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] int id)
        {
            try
            {
                _paisService.Delete(id);

                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                return Ok(_paisService.Browse());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] int id)
        {
            try
            {
                return Ok(_paisService.RecoverById(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
