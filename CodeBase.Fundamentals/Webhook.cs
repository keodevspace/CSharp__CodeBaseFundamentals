using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class WebhookController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post()
    {
        using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
        {
            var payload = await reader.ReadToEndAsync();

            // Aqui você pode processar o payload recebido
            System.Console.WriteLine($"Payload recebido: {payload}");

            return Ok();
        }
    }
}