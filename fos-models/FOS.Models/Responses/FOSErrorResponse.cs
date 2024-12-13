using Newtonsoft.Json;

namespace FOS.Models.Responses;

/// <summary>Represents a error response</summary>
public sealed class FOSErrorResponse
{
    /// <summary>Initializes the object with a error message and exception</summary>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception raised</param>
    public FOSErrorResponse(string message, Exception innerException) : this(message, innerException, null!)
    {
    }

    /// <summary>Initializes the object with a error message and exception</summary>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception raised</param>
    /// <param name="innerError"><see cref="FOSErrorResponse"/> instance of the the inner error</param>
    public FOSErrorResponse(string message, Exception innerException, FOSErrorResponse innerError)
    {
        Message = message;
        Exception = innerException;
        InnerError = innerError;
    }

    /// <summary>Initializes the object</summary>
    public FOSErrorResponse() : this(String.Empty, null!)
    {
    }

    /// <summary>Initializes the object with a error message</summary>
    /// <param name="message">Error message</param>
    public FOSErrorResponse(string message) : this(message, null!)
    {
    }

    /// <summary>Gets/sets any additional data for the error</summary>
    /// <value><see cref="Dictionary{TKey,TValue}"/></value>
    [JsonExtensionData]
    [JsonProperty(FieldName.AdditionalData, Order = FieldOrder.AdditionalData,
        Required = Required.Default)]
    public Dictionary<string, object> AdditionalData { get; set; } = default!;

    /// <summary>Gets or sets the exception object.</summary>
    /// <value>An instance of the <see cref="Exception"/> class.</value>
    [JsonIgnore]
    [JsonProperty(FieldName.Exception, Order = FieldOrder.Exception, Required = Required.Default)]
    public Exception Exception { get; set; }

    /// <summary>Gets or sets <see cref="FOSErrorResponse"/> for any inner error/exception</summary>
    /// <value><see cref="FOSErrorResponse"/></value>
    [JsonProperty(FieldName.InnerError, Order = FieldOrder.InnerError, Required = Required.Default)]
    public FOSErrorResponse InnerError { get; set; }

    /// <summary>Gets or sets the error messages.</summary>
    /// <value><see cref="string"/></value>
    [JsonProperty(FieldName.Message, Order = FieldOrder.Message, Required = Required.Default)]
    public string Message { get; set; }

    /// <summary>Gets the map list of validation errors.</summary>
    /// <value><see cref="IReadOnlyDictionary{TKey,TValue}"/> where TKey is <see cref="string"/> and TValue is <see cref="string"/> array.</value>
    [JsonProperty(FieldName.ValidationErrors, Order = FieldOrder.ValidationErrors,
        Required = Required.Default)]
    public Dictionary<string, string[]> ValidationErrors { get; set; } = default!;

    private struct FieldName
    {
        internal const string AdditionalData = "additionalData";
        internal const string Exception = "exception";
        internal const string InnerError = "innerError";
        internal const string Message = "message";
        internal const string ValidationErrors = "validationErrors";
    }

    private struct FieldOrder
    {
        internal const int AdditionalData = 9000;
        internal const int Exception = 1000;
        internal const int InnerError = 5000;
        internal const int Message = 2;
        internal const int ValidationErrors = 10;
    }
}