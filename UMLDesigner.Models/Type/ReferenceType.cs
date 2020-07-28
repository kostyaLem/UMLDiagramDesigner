namespace UMLDesigner.Models.Type
{
    /// <summary>
    /// Ссылочный тип данных
    /// </summary>
    public class ReferenceType : TypeBase
    {
        public override CreationType CreationType { get; }

        public override AccessModifierType AccessModifierType { get; }

        public override InMemoryStoredType StoredType { get; } = InMemoryStoredType.Reference;

        public ReferenceType ParentType { get; set; }

        public ReferenceType(string name, CreationType creationType, AccessModifierType modifierType) : base(name)
        {
            CreationType = creationType;
            AccessModifierType = modifierType;
        }
    }
}
