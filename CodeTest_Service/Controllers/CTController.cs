using CodeTest_Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CodeTest_Service.Controllers;

[Route("CT")]
public class CTController : BaseController
{
    private ICodeTestBusiness _codeTestBusiness;

    public CTController(ICodeTestBusiness codeTestBusiness)
    {
        _codeTestBusiness = codeTestBusiness;
    }

    [HttpPost("GetLongestIncreasingSubSequenceFromInputString")]
    public IActionResult GetLISubSequenceFromInputString(
        [FromBody] string integerSequence
    )
        => GenerateAPIResponse(
            _codeTestBusiness.GetLongestIncreasingSubSequenceFromString(integerSequence)
        );

    [HttpPost("GetLongestIncreasingSubSequenceFromFile")]
    public IActionResult GetLISubSequenceFromFile(
        [FromBody] string filePath
    ) 
        => GenerateAPIResponse(
            _codeTestBusiness.GetLongestIncreasingSubSequenceFromString(filePath)
        );
}
