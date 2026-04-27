using System;
using System.Collections.Generic;
using System.Text;

namespace projectCommand.Models
{
    class ComandoPause : ICommand
    {
        private Dispositivo _dispositivo;

        public ComandoPause(Dispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }

        public void Executar()
        {
            _dispositivo.DarPause();
        }
    }
}
