using System;
using System.Collections.Generic;
using System.Text;

namespace projectCommand.Models
{
    class ComandoHome : ICommand
    {
        private Dispositivo _dispositivo;

        public ComandoHome(Dispositivo dispositivo)
        {
            this._dispositivo = dispositivo;
        }
        
        public void Executar()
        {
            _dispositivo.IrParaHome();
        }
    }
}
