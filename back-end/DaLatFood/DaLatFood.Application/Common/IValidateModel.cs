using FluentValidation;
using FluentValidation.Results;

namespace DaLatFood.Application.Common;

public interface IValidateModel
{
    Task<ValidationResult> ValidateModelAsync(object model);
}