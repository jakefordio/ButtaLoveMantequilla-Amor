using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ButtaLove.Services;

public class ErrorHandlerService
{
        public static string GetModelStateErrors(ModelStateDictionary modelState)
        {
            List<KeyValuePair<string, string>> errors = new List<KeyValuePair<string, string>>();
            //get the fields with errors
            var fields = modelState.Where(ms => ms.Value.Errors.Any())
                .Select(err => new { err.Key, err.Value.Errors });
            //loop through each field and add to error list
            foreach (var field in fields)
            {
                var fieldKey = field.Key;
                var fieldErrors =
                    field.Errors.Select(err => new KeyValuePair<string, string>(fieldKey, err.ErrorMessage));
                errors.AddRange(fieldErrors);
            }
            string errorString = string.Empty;
            foreach (var err in errors)
            {
                errorString += $"\n {err.Key}: {err.Value} \n";
            }
            return errorString;
        }
}