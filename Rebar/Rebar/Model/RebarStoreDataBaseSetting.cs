
namespace Rebar.Model
{
    public class RebarStoreDataBaseSetting : IRebarStoreDataBaseSetting
    {
        public string AccountCollectionName { get; set; } = "Account";
        public string MenuCollectionName { get; set; } = string.Empty;
        public string OrderCollectionName { get; set; } = "Account";
        public string ShakeCollectionName {  get; set; }= "Shakes";
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
