
namespace DesignPatterns.Builder
{
    internal class PersonBuilder
    {
        private readonly Person _person = new();
        private PersonBuilder() { }

        public PersonBuilder Age(int age)
        {
            _person.Age = age;
            return this;
        }

        public PersonBuilder Name(string name)
        {
            _person.Name = name;
            return this;
        }

        public PersonBuilder Address(string address)
        {
            _person.Address = address;
            return this;
        }

        public Person Build()
        {
            return _person;
        }

        public static PersonBuilder Builder()
        {
            return new PersonBuilder();
        }
    }
}
