using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest_Business.Model;

/// <summary>
/// The response body conveyed out of the endpoint
/// </summary>
/// <typeparam name="T">Any type of data point to relay out</typeparam>
[ExcludeFromCodeCoverage]
public class APIResponse<T>
{
    public APIResponse(T data, string status, string message)
    {
        Data = data;
        Status = status;
        Message = message;
    }

    //Business result data to relay out
    public T Data { get; set; }

    //User friendly string status other then HTTP Status
    public string Status { get; set; }

    //Any message to detail in addition the status
    public string Message { get; set; }
}
