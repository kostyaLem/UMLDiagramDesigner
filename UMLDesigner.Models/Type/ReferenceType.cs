namespace UMLDesigner.Models.Type
{
    public class ReferenceType : TypeBase
    {
        public override string Name { get; set; }

        public override CreationType CreationType { get; }

        public override InMemoryStoredType StoredType { get; }

        public TypeBase ParentType { get; set; }

        public ReferenceType(string name, TypeBase parantType, CreationType creationType)
        {
            Name = name;
            ParentType = parantType;
            CreationType = creationType;

            StoredType = InMemoryStoredType.Reference;
        }
    }
}
