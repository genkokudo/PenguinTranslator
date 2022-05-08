using System.Threading.Tasks;

namespace PenguinTranslator.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
