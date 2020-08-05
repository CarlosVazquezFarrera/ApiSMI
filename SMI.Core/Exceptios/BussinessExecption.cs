namespace SMI.Core.Exceptios
{
    using System;
    public class BussinessExecption : Exception
    {
        #region Constructor
        public BussinessExecption()
        {

        }
        public BussinessExecption(string message) : base(message)
        {

        } 
        #endregion
    }
}
