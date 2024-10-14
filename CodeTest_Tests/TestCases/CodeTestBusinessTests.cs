using CodeTest_Business.Business;
using Xunit;

namespace CodeTest_Tests.TestCases;

public class CodeTestBusinessTests : TestCases
{
    [Fact]
    public void CodeTest_TestCase_01()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_1_Input);

        Assert.True(output.Data == TestCase_1_Output);
    }

    [Fact]
    public void CodeTest_TestCase_02()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_2_Input);

        Assert.True(output.Data == TestCase_2_Output);
    }

    [Fact]
    public void CodeTest_TestCase_03()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_3_Input);

        Assert.True(output.Data == TestCase_3_Output);
    }

    [Fact]
    public void CodeTest_TestCase_04()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_4_Input);

        Assert.True(output.Data == TestCase_4_Output);
    }

    [Fact]
    public void CodeTest_TestCase_05()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_5_Input);

        Assert.True(output.Data == TestCase_5_Output);
    }

    [Fact]
    public void CodeTest_TestCase_06()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_6_Input);

        Assert.True(output.Data == TestCase_6_Output);
    }

    [Fact]
    public void CodeTest_TestCase_07()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_7_Input);

        Assert.True(output.Data == TestCase_7_Output);
    }

    [Fact]
    public void CodeTest_TestCase_08()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_8_Input);

        Assert.True(output.Data == TestCase_8_Output);
    }

    [Fact]
    public void CodeTest_TestCase_09()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_9_Input);

        Assert.True(output.Data == TestCase_9_Output);
    }

    [Fact]
    public void CodeTest_TestCase_10()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_10_Input);

        Assert.True(output.Data == TestCase_10_Output);
    }

    [Fact]
    public void CodeTest_TestCase_11()
    {
        var codeTestbusiness = new CodeTestBusiness();
        var output = codeTestbusiness.GetLongestIncreasingSubSequenceFromString(TestCase_11_Input);

        Assert.True(output.Data == TestCase_11_Output);
    }
}
