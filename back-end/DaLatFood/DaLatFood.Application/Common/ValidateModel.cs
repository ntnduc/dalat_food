using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Application.Common;

public class ValidateModel : IValidateModel
{
    private readonly IServiceProvider _serviceProvider;

    public ValidateModel(IServiceProvider serviceCollection)
    {
        _serviceProvider = serviceCollection;
    }

    public Task<ValidationResult> ValidateModelAsync(object model)
    {
        var validatorType = typeof(IValidator<>).MakeGenericType(model.GetType());
        var validator = (IValidator)_serviceProvider.GetRequiredService(validatorType);

        var validationContextType = typeof(ValidationContext<>).MakeGenericType(model.GetType());
        var validationContext = (IValidationContext)Activator.CreateInstance(validationContextType, new [] {model } )!;

        return validator.ValidateAsync(validationContext);
    }
}