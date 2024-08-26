using Microsoft.JSInterop;

namespace LearnBlazor.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async Task ToastrSuccess(this IJSRuntime jSRuntime, string message)
        {
            // Directly invoking the JavaScript function to show a success toast
            await jSRuntime.InvokeVoidAsync("showToastr", "success", message);
        }

        public static async Task ToastrError(this IJSRuntime jSRuntime, string message)
        {
            // Directly invoking the JavaScript function to show an error toast
            await jSRuntime.InvokeVoidAsync("showToastr", "error", message);
        }
    }
}
