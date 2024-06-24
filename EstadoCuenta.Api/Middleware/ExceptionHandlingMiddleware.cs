using EstadoCuenta.Domain.Exceptions;
using FluentValidation;
using System.Net;
using System.Text.Json;

namespace EstadoCuenta.Api.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (ValidationException ex)
            {
                await HandleValidationExceptionAsync(httpContext, ex);
            }
            catch (NotFoundException ex)
            {
                await HandleNotFoundExceptionAsync(httpContext, ex);
            }
            catch (CreditLimitExceededException ex)
            {
                await HandleCreditLimitExceededExceptionAsync(httpContext, ex);
            }
            catch (PagoMinimoException ex)
            {
                await HandlePagoMinimoExceptionAsync(httpContext, ex);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandlePagoMinimoExceptionAsync(HttpContext httpContext, PagoMinimoException ex)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;

            var response = new
            {
                Title = "Minimum payment fee",
                Status = httpContext.Response.StatusCode,
                Detail = ex.Message
            };

            return httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private Task HandleCreditLimitExceededExceptionAsync(HttpContext httpContext, CreditLimitExceededException ex)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;

            var response = new
            {
                Title = "Not have enough credit available",
                Status = httpContext.Response.StatusCode,
                Detail = ex.Message
            };

            return httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private Task HandleNotFoundExceptionAsync(HttpContext httpContext, NotFoundException ex)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;

            var response = new
            {
                Title = "Resource not found",
                Status = httpContext.Response.StatusCode,
                Detail = ex.Message
            };

            return httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private static Task HandleValidationExceptionAsync(HttpContext context, ValidationException exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            var errors = exception.Errors
               .GroupBy(e => e.PropertyName)
               .ToDictionary(
                   g => g.Key,
                   g => g.Select(e => e.ErrorMessage).ToArray()
               );

            var response = new
            {
                Title = "Validation errors occurred",
                Status = context.Response.StatusCode,
                Errors = errors
            };

            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var response = new
            {
                Title = "An unexpected error occurred",
                Status = context.Response.StatusCode,
                Detail = exception.Message
            };

            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
