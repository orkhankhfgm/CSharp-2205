namespace Generic
{
    public class MultipleGenericClass<T, Z, D>
    {
        public Z Id { get; set; }
        public T Name { get; set; }
        public T Surname { get; set; }
        public D DateOfBirth { get; set; }

        public T GetName()
        {
            return Name;
        }
    }
}
