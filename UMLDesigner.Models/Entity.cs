using System;
using System.Collections.ObjectModel;
using UMLDesigner.Models.Type;

namespace UMLDesigner.Models
{
    /// <summary>
    ///
    /// </summary>
    public class Entity : ReferenceType
    {
        public ObservableCollection<Attribute> Attributes { get; set; }

        public ObservableCollection<Operation> Operations { get; set; }

        public Entity(string name, CreationType creationType, AccessModifierType modifierType) : base(name, creationType, modifierType)
        {

        }
    }
}
