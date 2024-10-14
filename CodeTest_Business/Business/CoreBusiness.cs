using CodeTest_Business.Model;

namespace CodeTest_Business.Business;

public class CoreBusiness
{
    #region BusinessUtilities

    internal static T[] SubArray<T>(T[] data, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(data, index, result, 0, length);
        return result;
    }

    internal static BusinessParameters ResetSubSequenceParam(BusinessParameters param)
    {
        param.CurrentSubSequenceStartIndex = param.CurrentSubSequenceStartIndex + param.CurrentSubSequenceLength + 1;
        param.CurrentSubSequenceLength = 0;

        return param;
    }

    internal static BusinessParameters SetLongestSequenceParam(BusinessParameters param)
    {
        param.LongestSubSequenceLength = param.CurrentSubSequenceLength;
        param.LongestSubSequenceStartIndex = param.CurrentSubSequenceStartIndex;

        param = ResetSubSequenceParam(param);

        return param;
    }
    #endregion

    #region FileInteraction

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

    #region ExceptionResponseMethods

    // Response object in case of an error / exception
    public static BusinessResult<T> GetErrorBusinessResult<T>(string message)
    {
        return new BusinessResult<T>(
            status: ReturnStatus.Error,
            message: message
         );
    }

    // Response object in case of no data found
    public static BusinessResult<T> GetNotFoundBusinessResult<T>(string message)
    {
        return new BusinessResult<T>()
        {
            Status = ReturnStatus.NotFound,
            Message = message,
            BusinessResponseCode = "NotFound"
        };
    }

    // Response object in case of no data found, but has to return enpty array
    public static BusinessResult<T> GetNotFoundBusinessResult<T>(T data, string message)
    {
        return new BusinessResult<T>()
        {
            Data = data,
            Status = ReturnStatus.NotFound,
            Message = message,
            BusinessResponseCode = "NotFound"
        };
    }

    // Response object to relay validation error messages
    public static BusinessResult<T> GetValidationBusinessResult<T>(string message)
    {
        return new BusinessResult<T>()
        {
            Status = ReturnStatus.ValidationError,
            Message = message,
            BusinessResponseCode = "ValidationError"
        };
    }
    #endregion
}
