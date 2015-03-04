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

    public class ExcavationStep : IUnitStep<IExcavationItem, IExcavatedItem>
    {
        bool IUnitStep<IExcavationItem, IExcavatedItem>.CanAccept(Type type)
        {
            return true;
        }
        
        void IUnitStep<IExcavationItem, IExcavatedItem>.Accept(IExcavationItem input)
        {
            throw new NotImplementedException();
        }

        IExcavatedItem IUnitStep<IExcavationItem, IExcavatedItem>.Return()
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
        private readonly List<IUnitStep>  _steps; 
        
        public ExcavationSite()
        {
            _timer = new Timer {Interval = 1000};
            _timer.Elapsed += OnTimerElapsed;

            _workItems = new Stack<IUnitItem>();

            var step = new ExcavationStep();

            _steps = new List<IUnitStep> { step };

           
        }

        public void Start()
        {
            _timer.Start();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (_workItems.Count < 1)
            {
                _workItems.Push(new ExcavationItem());
            }

            var nextWorkItem = _workItems.Pop();

            var workItemHandler = _steps.First() is IUnitStep<IUnitItem, IExcavatedItem>;

            int a = 0;

        }
    }
}
