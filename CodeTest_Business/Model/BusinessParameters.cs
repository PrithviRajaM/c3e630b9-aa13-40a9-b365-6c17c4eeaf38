namespace CodeTest_Business.Model;

public class BusinessParameters
{
    // Total length of the input integer array
    public int TotalSequenceLength { get; set; }

    
    // Starting index of the current iteration at respective iteration
    public int CurrentSubSequenceStartIndex { get; set; } = 1;

    // length of the current sub sequence at respective iteration
    public int CurrentSubSequenceLength { get; set; } = 0;

    
    // Starting index of the longest iteration at respective iteration
    public int LongestSubSequenceStartIndex { get; set; } = 1;

    // length of the longest sub sequence at respective iteration
    public int LongestSubSequenceLength { get; set; } = 0;

    
    public BusinessParameters(int totalSequenceLength)
    {
        TotalSequenceLength = totalSequenceLength;
    }
}
