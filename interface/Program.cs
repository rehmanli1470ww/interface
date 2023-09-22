namespace interfacee;

public class Program
{

    static void Main(string[] args)
    {
        Guid id=new Guid();
        Guid id1=new Guid();
        Guid id2=new Guid();
        Guid id3=new Guid();
        Guid id4=new Guid();
        DateTime dateTime1=new DateTime();
        DateTime dateTime2=new DateTime();
        DateTime dateTime3=new DateTime();
        List<Manager> managers = new List<Manager>();
        managers.Add(new(id, "Haci", "Hacili", 23, "hegfyg", 1200));
        managers.Add(new(id, "Haciler", "Hacilli", 28, "hegfgsdyg", 11100));
        List<Ceo> ceos = new List<Ceo>();
        ceos.Add(new(id1, "Bakir", "Bakirli", 27, "rrgf", 1200));
        ceos.Add(new(id2, "Zakir", "Zakirli", 29, "rrgf", 2300));
        List<Worker> workers = new List<Worker>();
        workers.Add(new(id3, "Fazil", "Fazilli", 29, "fuywgue", 3000, dateTime1, dateTime1));
        workers.Add(new(id4, "Ramil", "Ramilli", 30, "fuywgue", 30400, dateTime2, dateTime2));
        List<Client> clients = new List<Client>();
        clients.Add(new(id1, "Guya", "Guyadida", 34, "ugjkdjf", "retgr", 2300));
        clients.Add(new(id2, "ikram", "Ikramli", 33, "ugjkfefg", "asstretgr", 2500));

    }
}
