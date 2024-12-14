using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace FOS.Models.Exceptions;

/// <summary>Custom exception class for the 401 error.</summary>
[SuppressMessage("Roslynator", "RCS1194:Implement exception constructors.", Justification = "<Pending>")]
public sealed class FOSUnauthorizedException : FOSException
{
    /// <summary>Initializes the exception with a given message</summary>
    /// <param name="message">Error message</param>
    public FOSUnauthorizedException(string message) : base(HttpStatusCode.Unauthorized, message)
    {
    }

    /// <summary>Initializes the exception</summary>
    public FOSUnauthorizedException() : base(HttpStatusCode.Unauthorized)
    {
    }

    /// <summary>Initializes the exception with a given message and the original <see cref="Exception"/> instance</summary>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSUnauthorizedException(string message, Exception innerException) : base(HttpStatusCode.Unauthorized, message, innerException)
    {
    }
}