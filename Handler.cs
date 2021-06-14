using System;

namespace raminrahimzada
{
    public partial class Handler:IDisposable
    {
        //TODO write all dependencies here as ctor parameter once
        private readonly IDependency1 _dependency1;        
        public Handler(IDependency1 dependency1)
        {
            _dependency1=dependency1;
        } 
    }
}
