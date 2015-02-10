using System;

using Flonus.Core;

using Should;

namespace Flonus.Tests
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
