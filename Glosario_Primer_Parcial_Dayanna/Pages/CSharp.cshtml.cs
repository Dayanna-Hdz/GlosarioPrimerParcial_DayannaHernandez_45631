using Microsoft.AspNetCore.Mvc.RazorPages;
using Glosario_Primer_Parcial_Dayanna.Models;
using System.Collections.Generic;

namespace Glosario_Primer_Parcial_Dayanna.Pages
{
    public class CSharpModel : PageModel
    {
        public static List<Termino> GlosarioCSharp { get; set; } = new List<Termino>();

        public void OnGet()
        {
            if (GlosarioCSharp.Count == 0)
            {
                GlosarioCSharp.Add(new Termino
                {
                    Palabra = "class",
                    Definicion = "Define una clase en C#."
                });

                GlosarioCSharp.Add(new Termino
                {
                    Palabra = "List<T>",
                    Definicion = "Colección genérica de elementos."
                });

                GlosarioCSharp.Add(new Termino
                {
                    Palabra = "PageModel",
                    Definicion = "Clase base utilizada por Razor Pages."
                });
            }
        }
    }
}