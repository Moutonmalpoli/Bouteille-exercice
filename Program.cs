using ClassLibraryBouteille;
namespace BouteilleObjet

{
    internal class Program
    {
        static void Main(string[] args)
        {


            Bouteille a = new Bouteille(true, 1, 3);
            a.Remplir(2);
            a.Vider(-3);
            Console.WriteLine("Bouteille a: " + a.ToString());

            Bouteille b = new Bouteille(false, 3, 3);
            b.Ouvrir();
            Console.WriteLine("Bouteille b: " + b.ToString());

            Bouteille c = new Bouteille(true, 5, 5);
            c.Vider(5);
            c.Remplir(2);
            b.Transferer(c, 3);
            Console.WriteLine("Bouteille c: " + c.ToString());

            Console.WriteLine("Bouteille b après Transferer: " + b.ToString());



        }




    }

}

