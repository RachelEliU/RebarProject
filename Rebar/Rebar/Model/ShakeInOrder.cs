using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Rebar.Model
{
    public class ShakeInOrder
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public ShakeInOrder()
        {
        }
    }
}
