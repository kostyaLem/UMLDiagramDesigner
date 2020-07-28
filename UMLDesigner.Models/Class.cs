using System.Collections.ObjectModel;
using UMLDesigner.Models.Type;

namespace UMLDesigner.Models
{
    /// <summary>
    /// Класс диаграммы
    /// </summary>
    public class Class : ReferenceType
    {
        /// <summary>
        /// Атрибуты класса
        /// </summary>
        public ObservableCollection<Attribute> Attributes { get; set; }

        /// <summary>
        /// Операции класса
        /// </summary>
        public ObservableCollection<Operation> Operations { get; set; }

        public Class(string name, CreationType creationType, AccessModifierType modifierType) : base(name, creationType, modifierType)
        {

        }
    }
}
