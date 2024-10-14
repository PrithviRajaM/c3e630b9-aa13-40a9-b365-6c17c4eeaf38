using Microsoft.AspNetCore.Mvc;

namespace CodeTest_Service.Controllers
{
    public class CTController : Controller
    {
        [HttpPost("GetLongestIncreasingSubSequence")]
        public IActionResult GetLongestIncreasingSubSequence([FromBody] string integerSequence)
        {
            return Ok("");
        }
    }
}
