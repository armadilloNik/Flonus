using Flonus.Core;
using System;

namespace Flonus.ReferenceApp.Core
{
    public interface IMoveableFile { }
    public interface IMovedFile { }

    public class FileMover : IUnitStep<IMoveableFile, IMovedFile>
    {
        public void Accept(IMoveableFile input)
        {
            throw new NotImplementedException();
        }

        public IMovedFile Return()
        {
            throw new NotImplementedException();
        }
    }
}
