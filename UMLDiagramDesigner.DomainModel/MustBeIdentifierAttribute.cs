using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

namespace UMLDiagramDesigner.DomainModel
{
    public class MustBeIdentifierAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var provider = CodeDomProvider.CreateProvider("C#");
            return provider.IsValidIdentifier(value.ToString());
        }
    }
}