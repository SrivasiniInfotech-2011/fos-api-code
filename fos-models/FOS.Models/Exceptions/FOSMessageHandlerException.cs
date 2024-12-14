using FOS.Models.Responses;
using System.Diagnostics.CodeAnalysis;

namespace FOS.Models.Exceptions;

/// <summary>Exception class for the message handlers</summary>
[SuppressMessage("Roslynator", "RCS1194:Implement exception constructors.", Justification = "<Pending>")]
public sealed class FOSMessageHandlerException : FOSException
{
    private const string DefaultErrorMessage = "Exception in message handler.";

    /// <summary>Initializes the exception with the given <see cref="FOSMessageResponse"/> instance</summary>
    /// <param name="response"><see cref="FOSMessageResponse"/></param>
    public FOSMessageHandlerException(FOSMessageResponse response) : base(response.StatusCode, DefaultErrorMessage) => Response = response;

    /// <summary>Command/query response instance of type <see cref="FOSMessageResponse"/></summary>
    /// <value><see cref="FOSMessageResponse"/></value>
    public FOSMessageResponse Response { get; set; }
}