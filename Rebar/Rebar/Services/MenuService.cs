using MongoDB.Driver;
using Rebar.Model;

namespace Rebar.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMongoCollection<Shake> _shakes;
        public MenuService(IRebarStoreDataBaseSetting settings, IMongoClient mongoClient)
        {          
             var database = mongoClient.GetDatabase(settings.DatabaseName);
             _shakes = database.GetCollection<Shake>(settings.ShakeCollectionName);
        }
        public Shake CreateShake(Shake shake)
        {
            _shakes.InsertOne(shake);
            return shake;
        }

        public void DeleteShake(Guid id)
        {
            _shakes.DeleteOne(order => order.Id == id);
        }

        public Shake GetShake(Guid id)
        {
            return _shakes.Find(shake => shake.Id == id).FirstOrDefault();
        }

        public List<Shake> GetShakes()
        {
            return _shakes.Find(shake => true).ToList();
        }

        public void UpdateShake(Guid id, Shake shake)
        {
            _shakes.ReplaceOne(shake => shake.Id == id, shake);
        }
    }
}
