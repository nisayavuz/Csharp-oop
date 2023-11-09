namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();

            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyacKrediManager , tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}