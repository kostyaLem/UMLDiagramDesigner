using UMLDesigner.Models.Type;

namespace UMLDesigner.Models
{
    public class Operation
    {
        public string Name { get; set; }

        public TypeBase ReturnType { get; set; }

        public TypeBase[] OperationParameters { get; set; }

        public Operation(string name, TypeBase returnType, TypeBase[] operationParameters)
        {
            Name = name;
            ReturnType = returnType;
            OperationParameters = operationParameters;
        }
    }
}
