using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class TransactionModel : PageModel
{
    [BindProperty]
    public int CurrentBalance { get; set; } = 2456; // Example balance

    [BindProperty]
    public int SendAmount { get; set; } = 50; // Example amount to send

    [BindProperty]
    public string Recipient { get; set; }

    [BindProperty]
    public decimal Amount { get; set; }

    [BindProperty]
    public string Comments { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        return RedirectToPage("SuccessPage");
    }
}
