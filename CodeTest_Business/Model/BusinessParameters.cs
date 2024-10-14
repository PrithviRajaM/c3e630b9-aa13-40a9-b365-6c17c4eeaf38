namespace CodeTest_Business.Model;

public class BusinessParameters
{
    public int TotalSequenceLength { get; set; }
    public int CurrentSubSequenceStartIndex { get; set; } = 1;
    public int LongestSubSequenceStartIndex { get; set; } = 1;
    public int LongestSubSequenceLength { get; set; } = 0;
    public int CurrentSubSequenceLength { get; set; } = 0;

    public BusinessParameters(int totalSequenceLength)
    {
        TotalSequenceLength = totalSequenceLength;
    }
}
