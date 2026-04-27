using projectCommand.Models;

class Program
{
    static void Main(string[] args)
    {
        Dispositivo dispositivo = new Dispositivo();

        var controle = new ControleRemoto (
            dispositivo.DarPlay,
            dispositivo.DarPause,
            dispositivo.IrParaHome
        );

        controle.PressionarPlay();
        controle.PressionarPause();
        controle.PressionarHome();
        controle.PressionarPlay();
    }
}