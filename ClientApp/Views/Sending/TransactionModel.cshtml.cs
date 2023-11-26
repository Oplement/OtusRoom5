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
        // Initialization code or loading data if needed
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            // Handle the validation errors
            return Page();
        }

        // Handle the post (e.g., process the transaction)

        // Redirect to a confirmation page or the same page with a success message
        return RedirectToPage("SuccessPage");
    }
}
