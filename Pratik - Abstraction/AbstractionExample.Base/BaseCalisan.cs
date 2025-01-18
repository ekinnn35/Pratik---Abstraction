namespace AbstractionExample.Base
{
    public abstract class BaseCalisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public abstract void Gorev();

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Departman: {Departman}");
        }
    }
}
