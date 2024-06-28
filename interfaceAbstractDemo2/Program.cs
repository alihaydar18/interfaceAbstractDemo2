using interfaceAbstractDemo2;

namespace InterfaceAbstractDemo2;

    class Program
    {
        static void Main(string[] args)
        {
        AhbMuhendis ahbMuhendis = new AhbMuhendis("Ali Haydar","Bilgiç","Muhendis",50000);

        AhbMimar ahbMimar = new AhbMimar("Başak","Bilgiç","Mimar",45000);

        ArmMuhendis armMuhendis = new ArmMuhendis("Çağla", "Kara", "Muhendis", 70000);

        ArmMimar armMimar = new ArmMimar("Çiğdem", "Bilgiç", "Mimar", 60000);

        Console.WriteLine($"Adı: {ahbMuhendis.FirstName}, Soyadı: {ahbMuhendis.LastName}, Mesleği: {ahbMuhendis.Job}, Maaşı: {ahbMuhendis.Salary}");
        Console.WriteLine($"Promosyon eklenmiş toplam maaşı: {ahbMuhendis.ToplamMaasHesaplama()}");

        
        Console.WriteLine($"Adı: {ahbMimar.FirstName}, Soyadı: {ahbMimar.LastName}, Mesleği: {ahbMimar.Job}, Maaşı: {ahbMimar.Salary}");
        Console.WriteLine($"Promosyon eklenmiş toplam maaşı: {ahbMimar.ToplamMaasHesaplama()}");

        
        Console.WriteLine($"Adı: {armMuhendis.FirstName}, Soyadı: {armMuhendis.LastName}, Mesleği: {armMuhendis.Job}, Maaşı: {armMuhendis.Salary}");
        Console.WriteLine($"Toplam maaşı (promosyon yok): {armMuhendis.ToplamMaasHesaplama()}");
        
        Console.WriteLine($"Adı: {armMimar.FirstName}, Soyadı: {armMimar.LastName}, Mesleği: {armMimar.Job}, Maaşı: {armMimar.Salary}");
        Console.WriteLine($"Toplam maaşı (promosyon yok): {armMimar.ToplamMaasHesaplama()}");
    }
    }