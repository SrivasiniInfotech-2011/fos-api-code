using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace FOS.Models.Exceptions;

/// <summary>Custom exception for configuration errors.</summary>
[SuppressMessage("Roslynator", "RCS1194:Implement exception constructors.", Justification = "<Pending>")]
public sealed class FOSConfigurationException : FOSException
{
    /// <summary>Initializes the exception</summary>
    public FOSConfigurationException() : base(HttpStatusCode.UnprocessableEntity)
    {
    }

    /// <summary>Initializes the exception with the given message</summary>
    /// <param name="message">Error message</param>
    public FOSConfigurationException(string message) : base(HttpStatusCode.UnprocessableEntity, message)
    {
    }

    /// <summary>Initializes the exception with the given property name and message</summary>
    /// <param name="propertyName">Name of the property that raised the exception.</param>
    /// <param name="message">Error message</param>
    public FOSConfigurationException(string propertyName, string message) : base(HttpStatusCode.UnprocessableEntity, message)
    {
    }

    /// <summary>Initializes the exception with a given message and the original <see cref="Exception"/> instance</summary>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSConfigurationException(string message, Exception innerException) : base(HttpStatusCode.UnprocessableEntity, message, innerException)
    {
    }

    /// <summary>Initializes the exception with a given property name, message and the original <see cref="Exception"/> instance</summary>
    /// <param name="propertyName">Name of the property that raised the exception.</param>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Original exception that was raised.</param>
    public FOSConfigurationException(string propertyName, string message, Exception innerException) : base(HttpStatusCode.UnprocessableEntity, message,
        innerException)
    {
    }
}