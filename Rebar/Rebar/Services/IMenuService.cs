using Rebar.Model;

namespace Rebar.Services
{
    public interface IMenuService
    {
        Shake CreateShake(Shake shake);
        void DeleteShake(Guid id);
        Shake GetShake(Guid id);
        List<Shake> GetShakes();
        void UpdateShake(Guid id, Shake shake);
    }
}
