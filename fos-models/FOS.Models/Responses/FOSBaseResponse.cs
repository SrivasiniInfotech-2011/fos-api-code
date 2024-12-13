using Newtonsoft.Json;
using System.Net;

namespace FOS.Models.Responses;

/// <summary>Base response class from which other response classes are derived</summary>
public class FOSBaseResponse
{
    /// <summary>Initializes the default object</summary>
    public FOSBaseResponse() : this(HttpStatusCode.OK, String.Empty)
    {
    }

    /// <summary>Initializes the object with a given <see cref="HttpStatusCode"/></summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    public FOSBaseResponse(HttpStatusCode statusCode) : this(statusCode, String.Empty)
    {
    }

    /// <summary>Initializes the object with success flag and given message</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    /// /// <param name="message">Error message</param>
    public FOSBaseResponse(HttpStatusCode statusCode, string message)
    {
        StatusCode = statusCode;
        Error = new FOSErrorResponse(message);
    }

    /// <summary>Gets or sets the error information.</summary>
    /// <value>An instance of the <see cref="FOSErrorResponse"/> class.</value>
    [JsonProperty(FieldName.Error, Order = FieldOrder.Error, Required = Required.Default)]
    public FOSErrorResponse Error { get; set; }

    /// <summary>Gets a value that indicates if the HTTP response was successful.</summary>
    /// <returns><see langword="true" /> if <see cref="HttpStatusCode" /> is in the range 200-299; otherwise <see langword="false" />.</returns>
    [JsonIgnore]
    public bool IsSuccessStatusCode => StatusCode is >= HttpStatusCode.OK and <= (HttpStatusCode)299;

    /// <summary>Gets/sets the <see cref="HttpStatusCode"/></summary>
    /// <value><see cref="HttpStatusCode"/></value>
    [JsonIgnore]
    [JsonProperty(FieldName.StatusCode, Order = FieldOrder.StatusCode, Required = Required.Default)]
    public HttpStatusCode StatusCode { get; set; }

    private struct FieldName
    {
        internal const string Error = "error";
        internal const string StatusCode = "statusCode";
    }

    private struct FieldOrder
    {
        internal const int Error = 9000;
        internal const int StatusCode = 1;
    }
}