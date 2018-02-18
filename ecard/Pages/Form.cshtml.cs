using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using ecard.Model;

namespace ecard.Pages
{
    public class FormModel : PageModel
    {

        //CONNECT TO MY DATABASE 

        public Greetings bridgeGreetings { get; set; }

        private myDB _myDB { get; set; }

        public IConfiguration _Configuration { get; set; }


        public void OnGet()
        {

        }
    }
}