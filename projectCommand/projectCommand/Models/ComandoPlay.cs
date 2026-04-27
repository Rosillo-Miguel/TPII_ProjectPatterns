using System;
using System.Collections.Generic;
using System.Text;

namespace projectCommand.Models
{
    class ComandoPlay : ICommand
    {
        private Dispositivo _dispositivo;

        public ComandoPlay(Dispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }

        public void Executar()
        {
            _dispositivo.DarPlay();
        }
    }
}
