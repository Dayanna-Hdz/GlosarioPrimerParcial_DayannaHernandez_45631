using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Glosario_Primer_Parcial_Dayanna.Models;

namespace Glosario_Primer_Parcial_Dayanna.Pages
{
    public class htmlModel : PageModel
    {
        public static List<Termino> GlosarioHtml { get; set; } = new List<Termino>();

        public void OnGet()
        {
            if (GlosarioHtml.Count == 0)
            {
                GlosarioHtml.Add(new Termino
                {
                    Palabra = "<html>",
                    Definicion = "Etiqueta principal de una página web."
                });

                GlosarioHtml.Add(new Termino
                {
                    Palabra = "<form>",
                    Definicion = "Permite crear formularios."
                });

                GlosarioHtml.Add(new Termino
                {
                    Palabra = "<div>",
                    Definicion = "Contenedor para agrupar elementos."
                });
            }
        }
    }
}
