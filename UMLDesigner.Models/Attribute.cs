using UMLDesigner.Models.Type;

namespace UMLDesigner.Models
{
    public class Attribute
    {
        public string Name { get; set; }

        public TypeBase AttributeType { get; set; }

        public Attribute(string name, TypeBase typeBase)
        {
            Name = name;
            AttributeType = typeBase;
        }
    }
}
