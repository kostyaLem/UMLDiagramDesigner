using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMLDiagramDesigner.DomainModel
{
    public class CannotContainsNullValuesAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var collection = value as IEnumerable<object>;
            return !collection.Contains(null);
        }
    }
}