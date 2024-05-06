using System.Net;
using System.Security.Principal;

namespace PCCO104L.Encapsulation.MANAIG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What role would you like to play?");
            Console.WriteLine("");

            Champ mid = new Champ(6.8, "Mid Laner", "Solo");
            mid.champname = "Lux";
            mid.role = "Enchanter";
            mid.scndrole = "Secondary: Support";
            mid.Announcement();
            mid.second();



            Champ top = new Champ(8.5, "Top Lane", "Solo");
            top.champname = "Darius";
            top.role = "Bruiser";
            top.scndrole = "Secondary: Jungler";
            top.Announcement();
            top.second();



            Champ bot = new Champ(7.3, "Bottom Lane", "Needs Support");
            bot.champname = "Zeri";
            bot.role = "Marksman, Caster";
            bot.scndrole = "Secondary: Mid";
            top.Announcement();
            top.second();
            top.Closing();

        }
    }
}
public class Champ
{
    private string _Lane { get; set; }

    private double _PickRate { get; set; }

    private string _Laning { get; set; }

    public string champname { get; set; }

    public string role { get; set; }

    public string scndrole { get; set; }

    public Champ() { }

    public Champ(double pickrate)
    {
        _PickRate = pickrate;
    }

    public Champ(double pickrate, string lane, string laning) : this(pickrate)
    {
        _Lane = lane;
        _Laning = laning;
    }

    public void Announcement()
    {
        Console.WriteLine($"{_Lane} - Pickrate: {_PickRate} - {_Laning} - Champion: {champname} - {role} - Goodluck Summoner!");
    }

    public void second()
    {
        Console.WriteLine($"{scndrole}");
    }
    
    public void Closing()
    {
        Console.WriteLine("Please consult the Summoner's Guild for more roles and chmapions. Goodluck Summoner!");
    }

}