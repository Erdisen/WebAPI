using _02_WebAPIWithFakeData.Models;
using _02_WebAPIWithFakeData.Models.DummyData;
using Microsoft.AspNetCore.Mvc;

namespace _02_WebAPIWithFakeData.Controllers
{
    [Route("api/[controller]")]  // Buradaki route default olarak sunulur. ve URL olarak https:localhost:portNoapi/user şeklindedir.
    [ApiController]
    public class UserController : ControllerBase
    {
        // https:localhost:portNoapi/user URL ine get istediğinde bulunursak buradaki Get() metodumu tetiklenir.
        //public string Get()
        //{
        //    return "Merhaba Web API";
        //}
        private List<User> _kullanicilar = FakeData.GetUsers(200);

        [HttpGet] // Get isteğinde bulunduğumuzda oluşturacağı kullanıcı listesini döndüren bir metot yazalım.
        public List<User> Get()
        {
            return _kullanicilar;
        }

        //localhsot:PortNo/api/user/20
        //localhsot:PortNo/api/user/172

        [HttpGet("{id}")] // Get isteğinde bulunduğumuzda oluşturulan listeden ilgili id numarasına sahip kişi bilgisini bize Json olarak döndürsün
        public User Get(int id)
        {
            var user = _kullanicilar.FirstOrDefault(x => x.ID == id);
            return user;
        }

        //localhsot:PortNo/api/user/Aşkın/Yeşilkaya
        //localhsot:PortNo/api/user/Bilge/Adam

        [HttpGet("{adi}/{soyadi}")] // Get istediğinde bulunduğumuzda oluşturulan listeden ilgili adı ve soyadına sahip kişi biligisini bize json olarak döndürsün.
        public User Get(string adi,string soyadi)
        {
            var user = _kullanicilar.FirstOrDefault(x => x.FirstName == adi || x.LastName==soyadi);
            return user;
        }
        //TODO
        //1.HttpPost,HttpPut ve HttpDelete isteklerine yanıt veren metotlar oluşturun.
        //2.HttPost ile tetiklenen metot, Listeye bir kullanıcı eklesin.
        //3.HttpPut ile tetiklenen metot, listedeki bir kullanıcıyı güncellesin
        //4.HttpDelete ile tetiklenen metot, Listedeki bir kullanıcıyı silsin.
    }
}
