using System.Diagnostics.CodeAnalysis;

namespace CodeTest_Business.Model;

/// <summary>
/// A response business model to communicate with the controller and beyond
/// </summary>
/// <typeparam name="T"></typeparam>
public class BusinessResult<T>
{
    public BusinessResult(T data)
    {
        this.Status = ReturnStatus.OK;
        this.Data = data;
    }

    public BusinessResult(ReturnStatus status, string message)
    {
        this.Status = status;
        this.Message = message;
    }

    public ReturnStatus Status { get; set; }

    public T Data { get; set; }

    public string Message { get; set; } = "";
}
