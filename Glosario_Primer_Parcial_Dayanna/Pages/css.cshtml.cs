using Microsoft.AspNetCore.Mvc.RazorPages;
using Glosario_Primer_Parcial_Dayanna.Models;
using System.Collections.Generic;

namespace Glosario_Primer_Parcial_Dayanna.Pages
{
    public class cssModel : PageModel
    {
        public static List<Termino> GlosarioCss { get; set; } = new List<Termino>();

        public void OnGet()
        {
            if (GlosarioCss.Count == 0)
            {
                GlosarioCss.Add(new Termino
                {
                    Palabra = "color",
                    Definicion = "Cambia el color del texto."
                });

                GlosarioCss.Add(new Termino
                {
                    Palabra = "background-color",
                    Definicion = "Cambia el color de fondo."
                });

                GlosarioCss.Add(new Termino
                {
                    Palabra = "display:flex",
                    Definicion = "Permite acomodar elementos usando Flexbox."
                });
            }
        }
    }
}