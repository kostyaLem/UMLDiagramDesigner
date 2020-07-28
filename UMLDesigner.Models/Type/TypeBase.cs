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
        public virtual CreationType CreationType { get; set; }

        /// <summary>
        /// Способ хранения в памяти
        /// </summary>
        public virtual InMemoryStoredType StoredType { get; set; }
    }
}
