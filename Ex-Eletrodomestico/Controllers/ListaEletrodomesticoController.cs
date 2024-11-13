using Ex_Eletrodomestico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ex_Eletrodomestico.Controllers
{
    public class ListaEletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
{
                new Geladeira {Marca = "Brastemp", Modelo = "Brastemp Ative!", ConsumoEnergetico =  0.74, CapacidadeLitros = 375, TemFreezer = true },
                new Televisor {Marca = "Samsung", Modelo = " Samsung QLED 4K - Q60C", ConsumoEnergetico =90-130 , EhSmart = true, TamanhoTela = 65},
                new Televisor {Marca = "LG", Modelo = "75P7", ConsumoEnergetico = 15, EhSmart = true, TamanhoTela = 75 },

};

            return View(eletrodomesticos);
        }
    }
}
