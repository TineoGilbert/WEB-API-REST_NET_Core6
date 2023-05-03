using Microsoft.AspNetCore.Mvc;
using WEB_API_REST.Models;

namespace WEB_API_REST.Controllers
{
    [ApiController]
    [Route("client")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public dynamic ClientList()
        {
            List<Client> clients = new List<Client>
            {
                new Client
                {
                    id = "1",
                    name = "Gilbert E. Tineo",
                    email = "tineogilbert@gmail.com"
                }
            };

            return clients;
        }

        [HttpGet]
        [Route("listbyid")]
        public dynamic ListClientById(string _id)
        {
            return new Client
            {
                id = _id,

            };
        }

        [HttpPost]
        [Route("save")]
        public dynamic SaveClient(Client client)
        {
            client.id = "2";

            return new
            {
                success = true,
                message = "Client Registered",
                result = client
            };
        }
    }
}
