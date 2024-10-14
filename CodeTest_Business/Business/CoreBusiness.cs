using CodeTest_Business.Model;

namespace CodeTest_Business.Business;

public class CoreBusiness
{
    #region BusinessUtilities

    /// <summary>
    /// It splices the sub sequence from the original sequence with initial index and length of splice
    /// </summary>
    /// <returns>Returns sub sequence</returns>
    internal static T[] SubArray<T>(T[] data, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(data, index, result, 0, length);
        return result;
    }

    /// <summary>
    /// The CurrentSubSequence start index and length are reset
    /// </summary>
    /// <param name="param">Business params containing the business logic instance with counter values</param>
    internal static BusinessParameters ResetSubSequenceParam(BusinessParameters param)
    {
        param.CurrentSubSequenceStartIndex = param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength + 1;
        param.CurrentSubSequenceLength = 0;

        return param;
    }

    /// <summary>
    /// Sets the longest sub sequence param values
    /// </summary>
    internal static BusinessParameters SetLongestSequenceParam(BusinessParameters param)
    {
        param.LongestSubSequenceLength = param.CurrentSubSequenceLength;
        param.LongestSubSequenceStartIndex = param.CurrentSubSequenceStartIndex;

        param = ResetSubSequenceParam(param);

        return param;
    }
    #endregion

    #region FileInteraction

    /// <summary>
    /// Collectes and relays the file content string
    /// </summary>
    /// <returns>File content as string in business result data</returns>
    internal protected BusinessResult<string> GetFileData(string filePath)
    {
        try
        {
            return new BusinessResult<string>(File.ReadAllText(filePath));
        }
        catch (Exception ex) 
        {
            return new BusinessResult<string>(ReturnStatus.NotFound, ex.Message);
        }
    }
    #endregion
}
