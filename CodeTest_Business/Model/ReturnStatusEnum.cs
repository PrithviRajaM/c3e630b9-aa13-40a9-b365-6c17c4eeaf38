using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest_Business.Model;

/// <summary>
/// An internal return status definition for more elaborate response needs
/// </summary>
public enum ReturnStatus
{
    OK,
    MultipleRecordsUpdated,
    Error,
    NotFound,
    BadRequest,
    Unauthorized,
    Forbidden,
    MethodNotAllowed,
    Conflict,
    ValidationError,
}
