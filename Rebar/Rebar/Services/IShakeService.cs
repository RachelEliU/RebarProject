using Rebar.Model;

namespace Rebar.Services
{
    public interface IShakeService
    {
        Shake CreateShake(Shake shake);
        void DeleteShake(Guid id);
        Shake GetShake(Guid id);
        List<Shake> GetShakes();
        void UpdateShake(Guid id, Shake shake);
    }
}
