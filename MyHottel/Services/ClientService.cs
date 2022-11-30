using MyHottel.DataProvider;
using MyHottel.Models;

namespace Hottel.Services
{
    public class ClientService : BaseService<Client>
    {
        public ClientService(IDataProvider<Client> dataProvider) : base(dataProvider)
        {
        }

        protected override bool IsEntityValid(Client client, out string reason)
        {
            reason = "";
            if (client.Name=="")
            {
                reason += "Name is not null here\r\n";
            }
            if (client.Address=="")
            {
                reason += "Addres is not null here\r\n";
            }
            if (client.PhoneNumber=="")
            {
                reason += "Phonenumber is not null here\r\n";
            }
            return reason=="";
        }
    }
}
