using AbstractionExample.Base;

namespace AbstractionExample.Calisanlar
{
    public class ProjeYoneticisi : BaseCalisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }
}
