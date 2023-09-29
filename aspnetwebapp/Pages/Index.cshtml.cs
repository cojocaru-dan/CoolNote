using Microsoft.AspNetCore.Mvc.RazorPages;
using CoolNote;

namespace aspnetwebapp.Pages
{
    public class IndexModel : PageModel
    {
        public string Note => DataManager.Note;
        public int EditsAmount => DataManager.EditsAmount;
    }
}

