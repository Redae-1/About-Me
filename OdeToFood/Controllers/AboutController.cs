using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
       
        public string Phone()
        {
            return "571-351-9316";
        }
        
        public string Address()
        {
            return "USA";
        }
    }
}
