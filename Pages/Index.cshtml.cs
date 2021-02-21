using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;

namespace QrWeb.Pages
{
    public class IndexModel : PageModel
    {
        public byte[] Image;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Image = QrCoderGenerator.GenerateByteArray("https://www.linkedin.com/in/miltoncabastos/");
        }
    }
}
