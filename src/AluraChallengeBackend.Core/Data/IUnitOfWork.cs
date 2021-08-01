using System.Threading.Tasks;

namespace AluraChallengeBackend.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}