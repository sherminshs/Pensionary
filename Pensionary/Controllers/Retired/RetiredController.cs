using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pensionary.ApplicationServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Pensionary.Controllers.Retired
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetiredController : ControllerBase
    {
       // RetiredService retiredService=new RetiredService();
        //[HttpPost]
        //public async Task<IActionResult> PostRetired(DAL.Models.Retired ret)
        //{
        //      retiredService.AddRetired(ret);
        //    return CreatedAtAction("PostRetired", new {ret.RetiredId });
        //}


    }
}
