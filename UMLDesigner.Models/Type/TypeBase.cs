namespace UMLDesigner.Models.Type
{
    /// <summary>
    /// Базовый класс для всех типов
    /// </summary>
    public abstract class TypeBase
    {
        /// <summary>
        /// Имя типа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип создания типа
        /// </summary>
        public abstract CreationType CreationType { get; }

        /// <summary>
        /// Модификатор доступа
        /// </summary>
        public abstract AccessModifierType AccessModifierType { get; }

        /// <summary>
        /// Способ хранения в памяти
        /// </summary>
        public abstract InMemoryStoredType StoredType { get; }

        public TypeBase(string name)
        {
            Name = name;
        }
    }
}
