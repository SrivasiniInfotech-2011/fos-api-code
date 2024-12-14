using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace FOS.Models.Exceptions;

/// <summary>Custom exception class from which other exception classes are derived.</summary>
[SuppressMessage("Roslynator", "RCS1194:Implement exception constructors.", Justification = "<Pending>")]
public class FOSException : Exception
{
    /// <summary>Initializes the exception with the given status code and message</summary>
    public FOSException() => StatusCode = HttpStatusCode.InternalServerError;

    /// <summary>Initializes the exception with the given status code and message</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/> value</param>
    public FOSException(HttpStatusCode statusCode) => StatusCode = statusCode;

    /// <summary>Initializes the exception with the given status code and message</summary>
    /// <param name="message">Error message</param>
    public FOSException(string? message) : base(message) => StatusCode = HttpStatusCode.InternalServerError;

    /// <summary>Initializes the exception with the given status code and message</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/> value</param>
    /// <param name="message">Error message</param>
    public FOSException(HttpStatusCode statusCode, string? message) : base(message) => StatusCode = statusCode;

    /// <summary>Initializes the exception with the given status code, message and <see cref="Exception"/> instance</summary>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSException(string? message, Exception? innerException) : base(message, innerException) => StatusCode = HttpStatusCode.InternalServerError;

    /// <summary>Initializes the exception with the given status code, message and <see cref="Exception"/> instance</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/> value</param>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSException(HttpStatusCode statusCode, string? message, Exception? innerException) : base(message, innerException) =>
        StatusCode = statusCode;

    /// <summary>Gets/sets the <see cref="HttpStatusCode"/></summary>
    /// <value><see cref="HttpStatusCode"/></value>
    [JsonIgnore]
    [JsonProperty(FieldName.StatusCode, Order = FieldOrder.StatusCode, Required = Required.Default)]
    public HttpStatusCode StatusCode { get; set; }

    private struct FieldName
    {
        internal const string StatusCode = "statusCode";
    }

    private struct FieldOrder
    {
        internal const int StatusCode = 1;
    }
}