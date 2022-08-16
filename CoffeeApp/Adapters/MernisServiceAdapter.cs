using CoffeeAppwithMernis.Abstract;
using CoffeeAppwithMernis.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAppwithMernis.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(
                        Convert.ToInt64(customer.NationalityId),
                        customer.FirstName,
                        customer.LastName,
                        customer.DateofBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
