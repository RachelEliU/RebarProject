using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Rebar.Model
{
    public class ShakeInOrder
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public Guid IdShake { get; set; }
        public string Description { get;  set; }
        public int Price { get; private set; }
        public string Size { get; set; }
      
      
    }
}
