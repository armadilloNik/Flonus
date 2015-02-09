
// ReSharper disable TypeParameterCanBeVariant

namespace Flonus.Core
{
    public interface IUnitStep<TInput, TOutput>
    {
        void Accept(TInput input);
        TOutput Return();
    }
}
