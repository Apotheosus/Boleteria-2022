using System.Runtime.InteropServices;
using BoleteriaOnline.Web.Attributes;
using BoleteriaOnline.Web.Extensions;
using BoleteriaOnline.Web.Extensions.Response;
using Humanizer;
using SmartFormat;

namespace BoleteriaOnline.Web.Utils;
public static class WebResponse
{
    private static string ResolveErrorCode(ErrorMessage error) => new string(Enum.GetName(typeof(ErrorMessage), error).ToSnakeCase().ToArray()).ToUpper();

    public static WebResult<TResult> KeyError<TResult>(string key, string message) where TResult : class
    {
        ErrorMessage error = ErrorMessage.GenericValidation;
        return new WebResult<TResult>
        {
            ErrorCode = error,
            Success = false,
            Error = ResolveErrorCode(error),
            Message = error.GetDescription(),
            ErrorMessages = string.IsNullOrEmpty(message) ? new Dictionary<string, string[]>() : new Dictionary<string, string[]>() { { new string(key.ToSnakeCase().ToArray()), new string[] { message } } }
        };
    }

    public static WebResult<TResult> KeyError<TEntity, TResult>(string key, ErrorMessage error) where TResult : class
    {
        return new WebResult<TResult>
        {
            ErrorCode = error,
            Data = default,
            Error = ResolveErrorCode(error),
            Success = false,
            Message = "Se encontraron uno o más errores.",
            ErrorMessages = new Dictionary<string, string[]>() { { new string(key.ToSnakeCase().ToArray()), new string[] { Smart.Format(EnumExtensions.GetDescription(error), Options<TEntity>()) } } }
        };
    }

    public static WebResult<TResult> KeyError<TEntity, TResult>(string key, ErrorMessage error, TResult result) where TResult : class
    {
        return new WebResult<TResult>
        {
            ErrorCode = error,
            Data = result,
            Error = ResolveErrorCode(error),
            Success = false,
            Message = "Se encontraron uno o más errores.",
            ErrorMessages = new Dictionary<string, string[]>() { { new string(key.ToSnakeCase().ToArray()), new string[] { Smart.Format(EnumExtensions.GetDescription(error), Options<TEntity>()) } } }
        };
    }

    public static WebResult<TResult> KeyOk<TEntity, TResult>(string key, SuccessMessage message) where TResult : class
    {
        return new WebResult<TResult>
        {
            Data = default,
            Success = true,
            Message = "Correcto.",
            ErrorMessages = new Dictionary<string, string[]>() { { new string(key.ToSnakeCase().ToArray()), new string[] { Smart.Format(EnumExtensions.GetDescription(message), Options<TEntity>()) } } }
        };
    }

    public static WebResult<TResult> KeyOk<TEntity, TResult>(string key, SuccessMessage message, TResult result) where TResult : class
    {
        return new WebResult<TResult>
        {
            Data = result,
            Success = true,
            Message = "Correcto.",
            ErrorMessages = new Dictionary<string, string[]>() { { new string(key.ToSnakeCase().ToArray()), new string[] { Smart.Format(EnumExtensions.GetDescription(message), Options<TEntity>()) } } }
        };
    }


    /// <summary>
    /// Devuelve un objeto personalizado del sistema del tipo TResult con el mensaje de error computado de TEntity.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="error"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static WebResult<TResult> Error<TEntity, TResult>(ErrorMessage error, [Optional] string message) where TResult : class
    {
        return new WebResult<TResult>
        {
            ErrorCode = error,
            Error = ResolveErrorCode(error),
            Data = default,
            Success = false,
            Message = Smart.Format(EnumExtensions.GetDescription(error), Options<TEntity>()),
            ErrorMessages = string.IsNullOrEmpty(message) ? new Dictionary<string, string[]>() : new Dictionary<string, string[]>() { { "error", new string[] { message } } }
        };
    }

    public static WebResult<TResult> Error<TResult>(string message) where TResult : class
    {
        return new WebResult<TResult>
        {
            ErrorCode = ErrorMessage.GenericValidation,
            Error = "CUSTOM_ERROR",
            Data = default,
            Success = false,
            Message = message,
            ErrorMessages = new Dictionary<string, string[]>()
        };
    }

    private static ResponseOptions Options<TEntity>()
    {
        var options = new ResponseOptions()
        {
            Entity = typeof(TEntity).GetAttributeValue<HumanDescriptionAttribute, string>(c => c.Name),
            Gender = typeof(TEntity).GetAttributeValue<HumanDescriptionAttribute, GrammaticalGender>(c => c.Gender)
        };

        if (string.IsNullOrEmpty(options.Entity))
        {
            options.Entity = typeof(TEntity).Name.Humanize(LetterCasing.LowerCase);
            options.Gender = GrammaticalGender.Masculine;
        }
        return options;
    }

    public static WebResult<TResult> Ok<TResult>(TResult data) where TResult : class
    {
        return new WebResult<TResult>
        {
            Data = data,
            Success = true,
            Message = "Correcto.",
            ErrorMessages = new Dictionary<string, string[]>()
        };
    }

    public static WebResult<TResult> Ok<TResult>() where TResult : class
    {
        return new WebResult<TResult>
        {
            Data = default,
            Success = true,
            Message = "Correcto.",
            ErrorMessages = new Dictionary<string, string[]>()
        };
    }

    public static WebResult<TResult> Ok<TResult>(TResult data, string message) where TResult : class
    {
        return new WebResult<TResult>
        {
            Data = data,
            Success = true,
            Message = message,
            ErrorMessages = new Dictionary<string, string[]>()
        };
    }

    public static WebResult<TResult> Ok<TEntity, TResult>(TResult data, SuccessMessage message) where TResult : class
    {
        return new WebResult<TResult>
        {
            Data = data,
            Success = true,
            Message = Smart.Format(message.GetDescription(), Options<TEntity>()),
            ErrorMessages = new Dictionary<string, string[]>()
        };
    }

    public static WebResult<TResult> Ok<TEntity, TResult>(SuccessMessage message) where TResult : class
    {
        return new WebResult<TResult>
        {
            Data = default,
            Success = true,
            Message = Smart.Format(message.GetDescription(), Options<TEntity>()),
            ErrorMessages = new Dictionary<string, string[]>()
        };
    }

}
