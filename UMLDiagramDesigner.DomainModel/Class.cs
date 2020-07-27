using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace UMLDiagramDesigner.DomainModel
{
    public class Class : BindableBase
    {
        private string _name;
        private bool _isAbstract;

        public bool IsAbstract
        {
            get => _isAbstract;
            set => SetProperty(ref _isAbstract, value);
        }

        [Required(ErrorMessage = "Наименование класса не может быть пустым")]
        [MustBeIdentifier(ErrorMessage = "Наименование класса содержит недопустимые символы")]
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        [CannotContainsNullValues(ErrorMessage = "Коллекция атрибутов класса не должна содержать нулевые значения")]
        public ObservableCollection<Attribute> Attributes { get; }

        [CannotContainsNullValues(ErrorMessage = "Коллекция операций класса не может включать нулевые значения")]
        public ObservableCollection<Operation> Operations { get; }

        public Class()
        {
            Attributes = new ObservableCollection<Attribute>();
            Operations = new ObservableCollection<Operation>();
        }
    }
}