using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace AbpSample601.Web.Pages;

public class IndexModel : AbpSample601PageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
