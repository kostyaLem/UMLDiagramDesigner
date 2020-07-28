namespace UMLDesigner.Models.Type
{
    public class ValueType : TypeBase
    {
        public override string Name { get; set; }

        public override CreationType CreationType { get; }

        public override InMemoryStoredType StoredType { get; }

        public ValueType(string name, CreationType creationType)
        {
            Name = name;
            CreationType = creationType;

            StoredType = InMemoryStoredType.Value;
        }
    }
}
