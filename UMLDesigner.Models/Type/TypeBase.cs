namespace UMLDesigner.Models.Type
{
    public abstract class TypeBase
    {
        /// <summary>
        /// Имя типа
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Тип создания типа
        /// </summary>
        public abstract CreationType CreationType { get; }

        /// <summary>
        /// Способ хранения в памяти
        /// </summary>
        public abstract InMemoryStoredType StoredType { get; }
    }
}
