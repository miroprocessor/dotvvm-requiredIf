using dotvvm.validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace dotvvm.validation.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        public string Title { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Gender { get; set; }

        [RequiredIf(nameof(Gender), "1", ErrorMessage = "Age is required")]
        public int? Age { get; set; }

        public DefaultViewModel()
        {
            Title = "Hello from DotVVM!";
        }

        public void Save()
        { }
    }
}