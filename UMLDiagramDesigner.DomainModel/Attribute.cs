using System.ComponentModel.DataAnnotations;
using Prism.Mvvm;

namespace UMLDiagramDesigner.DomainModel
{
    public class Attribute : BindableBase
    {
        private AccessModifier _accessModifier;
        private Type _type;
        private string _name;

        public AccessModifier AccessModifier
        {
            get => _accessModifier;
            set => SetProperty(ref _accessModifier, value);
        }

        public Type Type
        {
            get => _type;
            set => SetProperty(ref _type, value);
        }

        [Required(ErrorMessage = "Наименование атрибута не может быть пустым")]
        [MustBeIdentifier(ErrorMessage = "Наименование атрибута содержит недопустимые символы")]
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}