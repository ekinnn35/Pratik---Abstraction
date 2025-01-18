using AbstractionExample.Base;

namespace AbstractionExample.Calisanlar
{
    public class SatisTemsilcisi : BaseCalisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
        }
    }
}
