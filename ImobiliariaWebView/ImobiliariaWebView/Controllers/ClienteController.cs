using ImobiliariaWebView.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ImobiliariaWebView.Controllers;

public class ClienteController : Controller
{
    private readonly string apiUrl = " https://localhost:7281/cliente";

    public async Task<IActionResult> Index()
    {
        List<Cliente> listaClintes = new List<Cliente>();

        using (var httpClient = new HttpClient())
        {
            using (var response = await httpClient.GetAsync(apiUrl))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                listaClintes = JsonConvert.DeserializeObject<List<Cliente>>(apiResponse);
            }
        }
        return View(listaClintes);
    }
}
