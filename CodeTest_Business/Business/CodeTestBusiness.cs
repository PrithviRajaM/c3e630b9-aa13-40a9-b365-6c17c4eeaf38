using CodeTest_Business.Interfaces;
using CodeTest_Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest_Business.Business;

/// <summary>
/// The requested problem solution is defined in this business class
/// </summary>
public class CodeTestBusiness : CoreBusiness, ICodeTestBusiness
{
    //No dependancy Injection required
    public CodeTestBusiness() { }

    public BusinessResult<string> GetLongestIncreasingSubSequenceFromFile(string filePath)
    {
        var response = GetFileData(filePath);

        return response.Status == ReturnStatus.OK 
            ? GetLongestIncreasingSubSequenceFromString(response.Data)
            : response;
    }

    public BusinessResult<string> GetLongestIncreasingSubSequenceFromString(string integerSequence)
    {
        var integerArray = integerSequence.Split(' ');
        var param = new BusinessParameters(integerArray.Length);

        do
        {
            if (int.TryParse(integerArray[param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength - 1], out int currentInteger)
                && int.TryParse(integerArray[param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength], out int nextInteger))
            {
                if (currentInteger < nextInteger)
                {
                    param.CurrentSubSequenceLength++;
                }
                else
                {
                    param = param.LongestSubSequenceLength >= param.CurrentSubSequenceLength
                        ? ResetSubSequenceParam(param)
                        : SetLongestSequenceParam(param);
                }
            }
            else
            {
                return new BusinessResult<string>(ReturnStatus.Error, "Integer conversion exception.");
            }

            param = (param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength == param.TotalSequenceLength
                && param.CurrentSubSequenceLength > param.LongestSubSequenceLength)
                    ? SetLongestSequenceParam(param)
                    : param;

        } while (param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength < param.TotalSequenceLength);

        return new BusinessResult<string>(string.Join(
            ' ',
            SubArray(
                integerArray,
                param.LongestSubSequenceStartIndex - 1,
                param.LongestSubSequenceLength + 1
            )
        ));
    }
}
