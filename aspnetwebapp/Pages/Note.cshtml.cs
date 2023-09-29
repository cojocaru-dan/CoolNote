using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoolNote;

namespace aspnetwebapp.Pages
{
    public class NoteModel : PageModel
    {
        [BindProperty, Required]
        public string Note
        {
            get => DataManager.Note;
            set => DataManager.Note = value;
        }

        public int EditsAmount
        {
            get => DataManager.EditsAmount;
            set => DataManager.EditsAmount = value;
        }

        public IActionResult OnPost()
        {
            EditsAmount++;
            return Redirect("/Index");
        }
    }
}
