using System;

namespace ControleChamadosRedeSuporte.Services.Exceptions
{
    public class NotFoundExcepion : ApplicationException
    {
public NotFoundExcepion(string message) : base(message)
        {
        }
    }
}
