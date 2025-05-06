using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace StringManipulationWeb.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty, Required]
        public string FirstName { get; set; }

        [BindProperty, Required]
        public string LastName { get; set; }

        public (string ConcatResult, string UppercaseResult, string NoSpaceResult)? Result { get; set; }

        // Func delegate com encadeamento
        public Func<string, string, string>? fullNamePipeline;

        public void OnPost()
        {
            // Criando os delegates
            Func<string, string, string> concat = (first, last) => $"{first} {last}";
            Func<string, string, string> toUpper = (first, last) => (first + " " + last).ToUpper();
            Func<string, string, string> removeSpaces = (first, last) => (first + last).Replace(" ", "");

            // Encadeando os delegates
            fullNamePipeline = concat;
            fullNamePipeline += toUpper;
            fullNamePipeline += removeSpaces;

            // Chama o delegate
            var concatenated = concat(FirstName, LastName);
            var uppercased = toUpper(FirstName, LastName);
            var noSpaces = removeSpaces(FirstName, LastName);

            // Exibindo os resultados
            Result = (concatenated, uppercased, noSpaces);
        }
    }
}
