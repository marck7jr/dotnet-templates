namespace Project1.Application.Behaviors;
public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TResponse>> _validators;

    public ValidationBehaviour(IEnumerable<IValidator<TResponse>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);

            var tasks = _validators
                .Select(x => x.ValidateAsync(context, cancellationToken));

            var validationResults = await Task.WhenAll(tasks);

            var failures = validationResults
                .SelectMany(x => x.Errors)
                .Where(x => x is not null)
                .ToList();

            if (failures.Any())
            {
                throw new ValidationException(failures);
            }
        }

        return await next();
    }
}