namespace UMLDesigner.Models.Type
{
    /// <summary>
    /// Способ хранения типа в памяти
    /// </summary>
    public enum InMemoryStoredType
    {
        /// <summary>
        /// Ссылочный тип
        /// </summary>
        Reference,

        /// <summary>
        /// Тип значения
        /// </summary>
        Value,

        /// <summary>
        /// Указатель
        /// </summary>
        Pointer
    }
}
