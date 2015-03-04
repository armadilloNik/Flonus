using System;

namespace Flonus.Core
{
    //public interface IUnitStep
    //{
    //}

    public interface IUnitStep<in TInput, out TOutput> // : IUnitStep
      //  where TInput : IUnitItem
      //  where TOutput : IUnitItem
    {
        bool CanAccept(Type type);
        void Accept(TInput input);
        TOutput Return();
    }
}
