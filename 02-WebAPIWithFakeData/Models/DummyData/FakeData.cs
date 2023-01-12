using Bogus;
using System.Reflection.Metadata.Ecma335;

namespace _02_WebAPIWithFakeData.Models.DummyData
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int count) // kaç tane user oluşturmak istediğimizi parametre olarak gönderiyoruz.
        {
            //Her defasında yeni userList oluşturmasını engelleyip, null olduğu zaman liste oluşturmasını isteyebiliriz. Eğer null değilse içinde bulunan aynı verileri geriye return eetsin diyebiliriz.
            if (_users==null)
            { 
                _users = new Faker<User>("tr",null)
                        .RuleFor(x => x.ID, faker => faker.IndexFaker + 1)
                        .RuleFor(x => x.FirstName, faker => faker.Name.FirstName())
                        .RuleFor(x => x.LastName, faker => faker.Name.LastName())
                        .RuleFor(x => x.Address, faker => faker.Address.FullAddress())
                        .Generate(count);

            }
            return _users;

        }
        
    }
}
