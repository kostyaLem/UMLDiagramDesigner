using UMLDesigner.Models.Type;

namespace UMLDesigner.Models
{
    /// <summary>
    /// Атрибут класса
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// Название атрибута
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Уоовень доступа атрибута
        /// </summary>
        public AccessModifierType ModifierType { get; set; }

        /// <summary>
        /// Тип атрибута
        /// </summary>
        public TypeBase AttributeType { get; set; }

        public Attribute(string name, TypeBase typeBase)
        {
            Name = name;
            AttributeType = typeBase;
        }
    }
}
