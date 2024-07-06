using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "Hello, world!";

        public void OnGet()
        {
        }

        public void OnPost(string name)
        {
            Message = $"Hello, {name}!";
        }
    }
}
