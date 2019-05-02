using System;

namespace ControleChamadosRedeSuporte.Models.ViewModel
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Message { get; set; } // Possibilitar mensagem de erro personalizadas
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}