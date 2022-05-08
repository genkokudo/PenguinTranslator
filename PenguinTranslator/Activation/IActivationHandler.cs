using System.Threading.Tasks;

namespace PenguinTranslator.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}
