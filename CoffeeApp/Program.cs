using CoffeeAppwithMernis.Abstract;
using CoffeeAppwithMernis.Adapters;
using CoffeeAppwithMernis.Concrete;

BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
baseCustomerManager.Save(new CoffeeAppwithMernis.Entities.Customer 
{ 
    DateofBirth = new DateTime(1995, 4, 11), 
    FirstName = "Emre", 
    LastName = "İpek", 
    NationalityId = "0" }
);