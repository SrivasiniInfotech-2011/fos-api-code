using System.Net;

namespace FOS.Models.Exceptions;

/// <summary>Custom exception for the Data client.</summary>
public class FOSDataException : FOSException
{
    /// <summary>Initializes the exception</summary>
    /// <summary>Initializes the exception with a given <see cref="HttpStatusCode"/></summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    public FOSDataException(HttpStatusCode statusCode) : base(statusCode) => StatusCode = statusCode;

    /// <summary>Initializes the exception with a given <see cref="HttpStatusCode"/>, message and response data</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    /// <param name="message">Error message</param>
    /// <param name="responseData">Complete response as a JSON string.</param>
    public FOSDataException(HttpStatusCode statusCode, string? message, string? responseData = null) : base(statusCode, message) =>
        ResponseData = responseData;

    /// <summary>Initializes the exception with a given <see cref="HttpStatusCode"/>, message, responseData and the original <see cref="Exception"/> instance</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    /// <param name="message">Error message</param>
    /// <param name="responseData">Complete response as a JSON string.</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSDataException(HttpStatusCode statusCode, string message, string? responseData, Exception innerException) : base(statusCode, message,
        innerException) => ResponseData = responseData;

    /// <summary>Gets the content data.</summary>
    /// <value><see cref="string"/></value>
    public string? ResponseData { get; set; }
}