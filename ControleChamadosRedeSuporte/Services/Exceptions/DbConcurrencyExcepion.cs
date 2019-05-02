using System;

namespace ControleChamadosRedeSuporte.Services.Exceptions
{
    public class DbConcurrencyExcepion : ApplicationException
    {
        public DbConcurrencyExcepion(string message) : base(message)
        {
        }
    }
}