using UMLDesigner.Models.Type;

namespace UMLDesigner.Models
{
    /// <summary>
    /// Операция класса
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Уровень доступа к операции
        /// </summary>
        public AccessModifierType ModifierType { get; set; }

        /// <summary>
        /// Возвращаемый тип
        /// </summary>
        public TypeBase ReturnType { get; set; }

        /// <summary>
        /// Параметры операции
        /// </summary>
        public TypeBase[] OperationParameters { get; set; }

        public Operation(string name, TypeBase returnType, TypeBase[] operationParameters)
        {
            Name = name;
            ReturnType = returnType;
            OperationParameters = operationParameters;
        }
    }
}
