using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace FOS.Models.Exceptions;

/// <summary>Custom exception class for the storage provider.</summary>
[SuppressMessage("Roslynator", "RCS1194:Implement exception constructors.", Justification = "<Pending>")]
public sealed class FOSStorageProviderException : FOSException
{
    /// <summary>Initializes the exception with a given message</summary>
    /// <param name="message">Error message</param>
    public FOSStorageProviderException(string? message) : base(HttpStatusCode.BadGateway, message)
    {
    }

    /// <summary>Initializes the exception with a given message and the original <see cref="Exception"/> instance</summary>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSStorageProviderException(string? message, Exception? innerException) : base(HttpStatusCode.BadGateway, message, innerException)
    {
    }

    /// <summary>Initializes the exception with a given message</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/> value</param>
    /// <param name="message">Error message</param>
    public FOSStorageProviderException(HttpStatusCode statusCode, string? message) : base(statusCode, message)
    {
    }

    /// <summary>Initializes the exception with a given message and the original <see cref="Exception"/> instance</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/> value</param>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSStorageProviderException(HttpStatusCode statusCode, string? message, Exception? innerException) : base(statusCode, message,
        innerException)
    {
    }
}