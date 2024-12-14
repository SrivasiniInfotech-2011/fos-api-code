using System.Diagnostics.CodeAnalysis;
using System.Net;
using FluentValidation.Results;

namespace FOS.Models.Exceptions;

/// <summary>Custom exception class for validations.</summary>
[SuppressMessage("Roslynator", "RCS1194:Implement exception constructors.", Justification = "<Pending>")]
public sealed class FOSValidationException : FOSException
{
    /// <summary>
    /// Overloaded constructor
    /// </summary>
    /// <param name="validationResult"><see cref="ValidationResult"/></param>
    public FOSValidationException(ValidationResult validationResult)
    {
        ValidationErrors = validationResult.Errors.Where(x => x != null).GroupBy(x => x.PropertyName, x => x.ErrorMessage,
            (propertyName, errorMessages) => new { Key = propertyName, Values = errorMessages.Distinct().ToArray() }).ToDictionary(x => x.Key, x => x.Values);
    }

    /// <summary>Initializes the exception with the <see cref="IReadOnlyDictionary{TKey,TValue}"/> collection of validation errors</summary>
    /// <param name="errors"><see cref="IReadOnlyDictionary{TKey,TValue}"/> where TKey is <see cref="string"/> and TValue is <see cref="string"/> array.</param>
    // #Localize
    public FOSValidationException(Dictionary<string, string[]> errors)
        : base(HttpStatusCode.BadRequest, "Validation Failure - One or more validation errors occurred")
        => ValidationErrors = errors;

    /// <summary>Gets the map list of validation errors.</summary>
    /// <value><see cref="IReadOnlyDictionary{TKey,TValue}"/> where TKey is <see cref="string"/> and TValue is <see cref="string"/> array.</value>
    public Dictionary<string, string[]> ValidationErrors { get; }
}