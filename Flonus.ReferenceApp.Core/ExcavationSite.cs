namespace Flonus.ReferenceApp.Core
{

    public interface IFlonusBootstrapStep
    {
        void Start();
    }

    public interface IExcavationSite : IFlonusBootstrapStep
    {
    }

    public class ExcavationSite : IExcavationSite
    {
        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}
