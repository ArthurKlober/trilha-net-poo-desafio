namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
<<<<<<< HEAD
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
=======
    public class Iphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
>>>>>>> 4d785142d17bd0cdf69068bf95e6b4e4e57a7534
    }
}