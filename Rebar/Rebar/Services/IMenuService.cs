using RebarProject.Models;

namespace RebarProject.Services
{
    public interface IMenuService
    {
        List<Shake> ShowMenu();
        Shake GetShake(Guid id);
        Shake Create(Shake shake);
        Shake Update(Shake shake);
        Shake Delete(Guid id);
    }
}
