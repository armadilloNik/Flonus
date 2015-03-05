using System;

namespace Flonus.Core
{
    public abstract class UnitStepBase
    {
        public abstract Type AcceptType { get; }
    }

    public abstract class UnitStep<TInput, TOutput> : UnitStepBase
        where TInput : IUnitItem
        where TOutput : IUnitItem
    {
        public abstract void Accept(TInput unitItem);
        public abstract TOutput Return();
    }
}
