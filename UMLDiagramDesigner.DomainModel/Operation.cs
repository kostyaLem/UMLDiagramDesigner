using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace UMLDiagramDesigner.DomainModel
{
    public class Operation : BindableBase
    {
        private AccessModifier _accessModifier;
        private string _name;
        private bool _isStatic;
        private Type _returnType;

        public AccessModifier AccessModifier
        {
            get => _accessModifier;
            set => SetProperty(ref _accessModifier, value);
        }

        [Required(ErrorMessage = "Наименование операции не может быть пустым")]
        [MustBeIdentifier(ErrorMessage = "Наименование операции содержит недопустимые символы")]
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public bool IsStatic
        {
            get => _isStatic;
            set => SetProperty(ref _isStatic, value);
        }

        public Type ReturnType
        {
            get => _returnType;
            set => SetProperty(ref _returnType, value);
        }

        [CannotContainsNullValues(ErrorMessage = "Коллекция параметров метода не может содержать нулевые значения")]
        public ObservableCollection<OperationParameter> Parameters { get; }

        public Operation() =>
            Parameters = new ObservableCollection<OperationParameter>();
    }
}