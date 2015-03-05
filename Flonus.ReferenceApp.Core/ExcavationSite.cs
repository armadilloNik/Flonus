using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

using Flonus.Core;

namespace Flonus.ReferenceApp.Core
{
    public interface IExcavatedItem : IUnitItem
    {
    }

    public class ExcavationStep : UnitStep<IExcavationItem, IExcavatedItem>
    {
        public override Type AcceptType => typeof(IExcavationItem);

        public override void Accept(IExcavationItem unitItem)
        {
            throw new NotImplementedException();
        }

        public override IExcavatedItem Return()
        {
            throw new NotImplementedException();
        }
    }
   
    public interface IExcavationSite : IFlonusBootstrapStep
    {
    }

    public class ExcavationSite : IExcavationSite
    {
        private readonly Timer _timer;
        private readonly Stack<IUnitItem> _workItems;
        private static List<UnitStepBase>  _steps; 
        
        public ExcavationSite()
        {
            _timer = new Timer {Interval = 1000};
            _timer.Elapsed += OnTimerElapsed;

            _workItems = new Stack<IUnitItem>();

            var step = new ExcavationStep();

            _steps = new List<UnitStepBase> { step };
        }

        public void Start()
        {
            _timer.Start();
        }

        static UnitStep<Tin, Tout> GetUnitStep<Tin, Tout>() 
            where Tin : IUnitItem
            where Tout : IUnitItem
        {
            var found = _steps.FindAll(step => step.AcceptType == typeof(Tin));

            return (UnitStep<Tin, Tout>)found.First();
        }


        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (_workItems.Count < 1)
            {
                _workItems.Push(new ExcavationItem());
            }

            var nextWorkItem = _workItems.Pop();

            var workItemHandler = _steps.First();

           

            int a = 0;

        }
    }
}
