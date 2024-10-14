using CodeTest_Business.Model;

namespace CodeTest_Business.Interfaces;

public interface ICodeTestBusiness
{
    BusinessResult<string> GetLongestIncreasingSubSequenceFromString(string integerSequence);
    BusinessResult<string> GetLongestIncreasingSubSequenceFromFile(string filePath);
}
