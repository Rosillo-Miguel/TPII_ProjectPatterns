using System;
using System.Collections.Generic;
using System.Text;

namespace projectCommand.Models
{
    public class ControleRemoto
    {
        public Action darPlay;
        public Action darPause;
        public Action irParaHome;

        
        public ControleRemoto(Action darPlay, Action darPause, Action irParaHome)
        {
            this.darPlay = darPlay;
            this.darPause = darPause;
            this.irParaHome = irParaHome;
        }

        public void PressionarPlay()
        {
            darPlay();
        }
        public void PressionarPause()
        {
            darPause();
        }
        public void PressionarHome()
        {
            irParaHome();
        }
    }
}
