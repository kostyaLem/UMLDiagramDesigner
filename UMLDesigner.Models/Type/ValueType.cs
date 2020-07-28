namespace UMLDesigner.Models.Type
{
    public class ValueType : TypeBase
    {
        public override CreationType CreationType { get; }

        public override AccessModifierType AccessModifierType { get; }

        public override InMemoryStoredType StoredType { get; } = InMemoryStoredType.Value;

        public ValueType(string name, CreationType creationType, AccessModifierType modifierType) : base(name)
        {
            CreationType = creationType;
            AccessModifierType = modifierType;
        }
    }
}
