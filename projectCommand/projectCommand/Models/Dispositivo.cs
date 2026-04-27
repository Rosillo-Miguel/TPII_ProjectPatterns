using System;
using System.Collections.Generic;
using System.Text;

//Receiver: Ele recebe a interação dos comandos e executa as ações correspondentes.
//Ele é responsável por realizar as operações reais quando um comando é executado.
//O Receiver pode ser uma classe que representa o dispositivo ou sistema que está sendo controlado pelos comandos.

//Neste caso, o Receiver seria um dispositivo, como uma TV, um sistema de som ou qualquer outro aparelho
//eletrônico que possa ser controlado pelos comandos de play, pause, etc.

namespace projectCommand.Models
{
    public class Dispositivo
    {
        public void DarPlay()
        {
            Console.WriteLine("Reproduzindo...");
        }

        public void DarPause() 
        { 
            Console.WriteLine("STOP"); 
        }

        public void IrParaHome()
        {
            Console.WriteLine("Voltando ao menu Home");
        }

        //public int MudarVolume(int volumeAnterior, int volumeNovo)
        //{
        //    Console.WriteLine($"Mudando o volume de {volumeAnterior} para {volumeNovo}");
        //    return volumeNovo;
        //}
    }
}
