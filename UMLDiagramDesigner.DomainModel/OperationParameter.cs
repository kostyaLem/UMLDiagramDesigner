using Prism.Mvvm;
using System.ComponentModel.DataAnnotations;

namespace UMLDiagramDesigner.DomainModel
{
    public class OperationParameter : BindableBase
    {
        private string _name;
        private Type _type;

        public Type Type
        {
            get => _type;
            set => SetProperty(ref _type, value);
        }

        [Required(ErrorMessage = "Наименование параметра операции не может быть пустым")]
        [MustBeIdentifier(ErrorMessage = "Наименование операции содержит недопустимые символы")]
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}