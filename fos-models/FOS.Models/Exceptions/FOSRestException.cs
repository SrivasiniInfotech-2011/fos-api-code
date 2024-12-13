using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace FOS.Models.Exceptions;

///<summary>Custom exception class for REST call exceptions.</summary>
[SuppressMessage("Roslynator", "RCS1194:Implement exception constructors.", Justification = "<Pending>")]
public sealed class FOSRestException : FOSException
{
    /// <summary>Initializes the exception with a given <see cref="HttpStatusCode"/></summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    public FOSRestException(HttpStatusCode statusCode) : base(statusCode) => StatusCode = statusCode;

    /// <summary>Initializes the exception with a given <see cref="HttpStatusCode"/>, message and response data</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    /// <param name="message">Error message</param>
    /// <param name="responseData">Complete response as a JSON string.</param>
    public FOSRestException(HttpStatusCode statusCode, string? message, string? responseData = null) : base(statusCode, message) =>
        ResponseData = responseData;

    /// <summary>Initializes the exception with a given <see cref="HttpStatusCode"/>, message, responseData and the original <see cref="Exception"/> instance</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    /// <param name="message">Error message</param>
    /// <param name="responseData">Complete response as a JSON string.</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSRestException(HttpStatusCode statusCode, string message, string? responseData, Exception innerException) : base(statusCode, message,
        innerException) => ResponseData = responseData;

    /// <summary>Gets the content data.</summary>
    /// <value><see cref="string"/></value>
    public string? ResponseData { get; set; }
}