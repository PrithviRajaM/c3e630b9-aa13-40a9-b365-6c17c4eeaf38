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

    /// <summary>
    /// Landing method to find the subsequence from file input
    /// </summary>
    /// <param name="filePath">Path of file as string</param>
    /// <returns>Return business result with subsequence in data or respective messages are stated</returns>
    public BusinessResult<string> GetLongestIncreasingSubSequenceFromFile(string filePath)
    {
        // Data collectd from File path
        var response = GetFileData(filePath);

        return response.Status == ReturnStatus.OK 
            ? GetLongestIncreasingSubSequenceFromString(response.Data)
            : response;
    }

    /// <summary>
    /// Landing method to find the subsequence from string input
    /// </summary>
    /// <param name="integerSequence">string input</param>
    /// <returns>Return business result with subsequence in data or respective messages are stated</returns>
    public BusinessResult<string> GetLongestIncreasingSubSequenceFromString(string integerSequence)
    {
        //Input string is split in to array
        var integerArray = integerSequence.Split(' ');
        var param = new BusinessParameters(integerArray.Length);

        do
        {
            // Each integer's string are converted into int
            if (int.TryParse(integerArray[param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength - 1], out int currentInteger)
                && int.TryParse(integerArray[param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength], out int nextInteger))
            {
                // Check of the next integer is greater
                if (currentInteger < nextInteger)
                {
                    //Then increment the current sub sequence length value
                    param.CurrentSubSequenceLength++;
                }
                else
                {
                    // Else, if so far recorded longest sub sequence is greater then reset the current counter,
                    // else record the new longest sub sequence values then reset the current counter
                    param = param.LongestSubSequenceLength >= param.CurrentSubSequenceLength
                        ? ResetSubSequenceParam(param)
                        : SetLongestSequenceParam(param);
                }
            }
            else
            {
                // Return if any once of the integer's string can't get converted to int
                return new BusinessResult<string>(ReturnStatus.Error, "Integer conversion exception.");
            }

            // In case of the end of sequence, check between current and longest sub sequence is managed
            param = (param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength == param.TotalSequenceLength
                && param.CurrentSubSequenceLength > param.LongestSubSequenceLength)
                    ? SetLongestSequenceParam(param)
                    : param;

        // The loop is continued until the end of the file
        } while (param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength < param.TotalSequenceLength);

        // The sub sequence is built with ' ' (single space) similar to the input.
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
