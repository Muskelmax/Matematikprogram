using System;

namespace matematik_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string navn;
            double sidelængde;
            double indvendigOmkreds;
            double sandkasseAreal;
            double sandkasseVolumen;
            double cotangens = 1.732051;
            double hVægt;
            double ture;
            double bredde;
            double længde;
            double højde;
            
            
            Console.Write("Navn: ");
            navn = Console.ReadLine();
            Console.Write("Polygonens indre sidelængde i m: ");
            sidelængde = Convert.ToDouble(Console.ReadLine());
            Console.Write("Trailerens bredde: ");
            bredde = Convert.ToDouble(Console.ReadLine());
            Console.Write("Trailerens længde: ");
            længde = Convert.ToDouble(Console.ReadLine());


            
            //1.1

            indvendigOmkreds = sidelængde * 6;

            //1.2
            
            //1.3
            sandkasseAreal = 0.25 * 6 *sidelængde * sidelængde * cotangens;
            sandkasseVolumen = sandkasseAreal * 0.4;

            //1.4

            hVægt = sandkasseVolumen * 1700;

            //1.5

            ture = hVægt / 400;

            //1.6

            højde = (400000 / 1.4) / (længde * bredde);

            
            Console.WriteLine("Aflevering nr. 11_" + navn + "\nByg en sekskantet sandkasse \nSandkassen skal have en form som en regulær sekskant og skal have en indvendig sidelængde på 1,23 meter. \n(indset evt. billede)");
            Console.WriteLine("\n1.1 Hvad er den indvendige omkreds af sandkassen? \nfor at finde frem til løsningen multiplicerer jeg polygonens sidelængder med antallet af sider:\n6*" + sidelængde + "m = " + indvendigOmkreds +"m");
            Console.WriteLine("\n1.2 Lav en målfast arbejdstegning med sidelængde og diagonal påført tegningen.\n(for at lave polygonen, lav punkt A=("+ sidelængde +",0) og punkt B=("+ sidelængde *2 +",0). vælg regulær polygon og vælg derefter de to punkter og sæt antal siderne på 6\nvælg derefter Længde og marker to punkter ved siden af hinanden og derefter overfor hinanden.)\nJeg startede med at lave to punkter der havde polygonens sidelængde som afstand. Derefter lavede jeg en regulær sekskantet polygon og brugte Længde værktøjet til at finde fremtil polygonens sidelængde og diameter.\n(indsæt billede)");
            Console.WriteLine("\n1.3 Hvor mange m3 sand kan der være i sandkassen?\nJeg regnede polygonens overflade areal ud med følgende formel:\n1/4*6*"+ sidelængde +"m cotangens(pi/6) = "+ Math.Round(sandkasseAreal,2) +"m2\nJeg multiplicerede resultatet med 0,4, for at regne sandkassens volumen ud:\n"+ sidelængde +"m2*0,40m = "+ Math.Round(sandkasseVolumen, 2) +"m3");
            Console.WriteLine("\n1.4 Hvad er den højeste vægt af alt sandet i sandkassen i kg?\nJeg regnede sandets højeste massefylde ud, og multiplicerede det med sandkassens volumen i cm3:\n"+ Math.Round(sandkasseVolumen, 2)*1000000 +"*1,7 = "+ Math.Round(hVægt,2)*1000 +"g\nSå regende jeg sandets vægt om til kg:\n"+ Math.Round(hVægt,2)*1000 +"g = "+ Math.Round(hVægt, 2) +"kg");
            Console.WriteLine("\n1.5 Hvor mange gange skal faren køre frem og tilbage?\nJeg dividerede sandets vægt med trailerens maks. belastning for at regne mig frem til antallet af turene faren skulle bruge:\n"+ Math.Round(hVægt, 2) +"kg/400 = "+ Math.Round(ture, 2) +"\nAltså 7 ture.");
            Console.WriteLine("\n1.6 Hvor højt må sandet max. gå til, for at der ikke bliver lastet for meget?\nJeg stillede en ligning op, hvor jeg først regnede trailerens maksimale rumfang ud og dividerede det derefter med trailerens grundflade, for at komme frem til højden:\n(400000 / 1.4) / ("+ længde +"*"+ bredde +") = "+ Math.Round(højde,2));
            



            //Stop program
            Console.ReadLine();
            
            
            
        }
    }
}
