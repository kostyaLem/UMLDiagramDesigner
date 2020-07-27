using Prism.Mvvm;
using System.ComponentModel.DataAnnotations;

namespace UMLDiagramDesigner.DomainModel
{
    public class Type : BindableBase
    {
        private string _name;

        [Required(ErrorMessage = "Наименование типа данных не может быть пустым")]
        [MustBeIdentifier(ErrorMessage = "Наименование типа данных содержит недопустимые символы")]
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}