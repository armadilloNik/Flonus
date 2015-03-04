namespace Flonus.Core
{
    public interface IUnitStep<in TInput, out TOutput>
        where TInput : IUnitItem
        where TOutput : IUnitItem
    {
        void Accept(TInput input);
        TOutput Return();
    }
}
