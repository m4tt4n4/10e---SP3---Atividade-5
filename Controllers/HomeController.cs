using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Henrique M. Mattana", "123.456.789-00", "henrique.mattana@sp.senai.br", "Cristal");
        Cliente cliente2 = new Cliente(02, "Fulano", "123.456.789-00", "fulano@sp.senai.br", "Bug");
        Cliente cliente3 = new Cliente(03, "Ciclano", "123.456.789-00", "ciclano@sp.senai.br", "Ted");
        Cliente cliente4 = new Cliente(04, "Beltrano", "123.456.789-00", "beltrano@sp.senai.br", "DarthVader");
        Cliente cliente5 = new Cliente(05, "Yoda", "123.456.789-00", "yodinha@sp.senai.br", "MasterYI");

        // Lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        // Instacias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "12.345.678/9000-00", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "C# PET S/A", "12.345.678/9000-00", "c-sharp@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "C# PET S/A", "12.345.678/9000-00", "c-sharp@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "C# PET S/A", "12.345.678/9000-00", "c-sharp@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(05, "C# PET S/A", "12.345.678/9000-00", "c-sharp@pet.org");

        //Lista de fornecedores e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
