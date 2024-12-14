using System.Net;
using Newtonsoft.Json;

namespace FOS.Models.Responses;

/// <summary>Base class from which all message responses are derived</summary>
/// <see cref="FOSBaseResponse"/>
[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class FOSMessageResponse : FOSBaseResponse
{
    /// <summary>Initializes the object with success</summary>
    public FOSMessageResponse()
    {
    }

    /// <summary>Initializes the object with success flag and given message</summary>
    /// <param name="statusCode"><see cref="HttpStatusCode"/></param>
    /// /// <param name="message">Error message</param>
    public FOSMessageResponse(HttpStatusCode statusCode, string message) : base(statusCode, message)
    {
    }

    /// <summary><see langword="true"/> if request is valid; otherwise <see langword="false"/></summary>
    /// <value><see cref="bool"/></value>
    [JsonProperty(FieldName.IsRequestValid, Order = FieldOrder.IsRequestValid,
        Required = Required.Default)]
    public bool IsRequestValid => Error.ValidationErrors!=null && Error.ValidationErrors.Count==0;

    /// <summary>Gets/sets the message command/query</summary>
    /// <value><see cref="object"/></value>
    [JsonProperty(FieldName.Request, Order = FieldOrder.Request, Required = Required.Default)]
    public object? Request { get; set; }

    /// <summary>Gets/sets the request type</summary>
    /// <value><see cref="Type"/></value>
    // [JsonProperty(FieldName.Type, Order = FieldOrder.Type, Required = Required.Default)]
    [JsonIgnore]
    public Type? RequestType { get; set; }

    private struct FieldName
    {
        internal const string IsRequestValid = "isRequestValid";
        internal const string Request = "request";
    }

    private struct FieldOrder
    {
        internal const int IsRequestValid = 2000;
        internal const int Request = 2001;
    }
}