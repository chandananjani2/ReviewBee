using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnet_core_dotnet_core.Pages
{
// Forth commit3
    public class PrivacyModel : PageModel
    {
        public string sqlCS { get; set; }

        public PrivacyModel(AppConfig appconfig)
        {
            sqlCS = appconfig.sqlCS;
        }

        public void OnGet()
        {
        }
    }
}
