using Hottel.Services;
using MyHottel.DataProvider;
using MyHottel.Models;

namespace MyHottel.Services
{
    public class PersonService : BaseService<Person>
    {
        public PersonService(IDataProvider<Person> dataProvider) : base(dataProvider)
        {

        }

        protected override bool IsEntityValid(Person person, out string reason)
        {
            reason = "";
            if (person.Name == "")
            {
                reason += "Name is not null here\r\n";
            }
            if (person.Address == "")
            {
                reason += "Addres is not null here\r\n";
            }
            if (person.PhoneNumber == "")
            {
                reason += "Phonenumber is not null here\r\n";
            }
            return reason == "";
        }
    }
}
