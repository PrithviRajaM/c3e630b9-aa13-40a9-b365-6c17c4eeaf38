using CodeTest_Business.Business;
using Xunit;

namespace CodeTest_Tests.TDDCases;

public class CodeTestTestCases
{
    private const string _inputString = "6 1 5 9 2";
    private const string _invalidInputString = "6 1 A 9 2";
    private const string _NoSequenceInputString = "6 5 4 3 2 1";
    private const string _SingleSequenceInputString = "3 4 5 6 7 9";

    private const string _outputString = "1 5 9";

    // LI - LongestIncreasingSubSequence

    [Fact]
    public void Get_LI_SubSequence_With_Success_Outcome()
    {
        var business = new CodeTestBusiness();
        var response = business.GetLongestIncreasingSubSequenceFromString(_inputString);

        Assert.Equal(_outputString, response);
    }

    [Fact]
    public void Get_LI_SubSequence_With_Invalid_Input_Sequence()
    {
        var business = new CodeTestBusiness();
        var response = business.GetLongestIncreasingSubSequenceFromString(_invalidInputString);

        //Implement Business Result outcome
        Assert.Equal("", response);
    }

    [Fact]
    public void Get_LI_SubSequence_With_No_Sequence()
    {
        var business = new CodeTestBusiness();
        var response = business.GetLongestIncreasingSubSequenceFromString(_NoSequenceInputString);

        Assert.Equal("6", response);
    }

    [Fact]
    public void Get_LI_SubSequence_With_Entire_Input_As_One_Sequence()
    {
        var business = new CodeTestBusiness();
        var response = business.GetLongestIncreasingSubSequenceFromString(_SingleSequenceInputString);

        Assert.Equal(_SingleSequenceInputString, response);
    }

}
