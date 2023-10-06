using InterfaceAnstractDemo.Abstract;

namespace InterfaceAnstractDemo.Entities
{
    public class Costumer:IEntity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}