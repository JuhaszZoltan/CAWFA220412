using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalapacsConsole
{
    internal class Program
    {
        private static List<Versenyzo> _versenyzok = new List<Versenyzo>();

        static void Main()
        {
            Feladat04();
            Feladat05();
            Feladat06();
            Feladat09();
            Feladat10();
            Console.ReadKey(true);
        }

        private static void Feladat10()
        {
            using (var sw = new StreamWriter(
                path: "..\\..\\src\\Dontos2012.txt",
                append: false,
                encoding: Encoding.UTF8))
            {
                var dontosok = _versenyzok
                    .OrderByDescending(v => v.Eredmeny)
                    .ToArray();

                Array.Resize(ref dontosok, 12);

                sw.WriteLine("Helyezés;Név;Csoport;" +
                    "Nemzet;NemzetKód;Sorozat;Eredmény");

                int helyezes = 1;
                foreach (var d in dontosok)
                {
                    sw.WriteLine(
                        $"{helyezes};{d.Nev};{d.Csoport};" +
                        $"{d.Nemzet};{d.Kod};{d.Sorozat};{d.Eredmeny}");
                    helyezes++;
                }
            }

        }

        private static void Feladat09()
        {
            var nyertes = _versenyzok
                .OrderByDescending(v => v.Eredmeny)
                .First();

            Console.WriteLine("9. feladat: " +
                "a selejtező nyertese:\n" +
                $"\tNév: {nyertes.Nev}\n" +
                $"\tCsoport: {nyertes.Csoport}\n" +
                $"\tNemzet: {nyertes.Nemzet}\n" +
                $"\tNemzet kód: {nyertes.Kod}\n" +
                $"\tSorozat: {nyertes.Sorozat}\n" +
                $"\tEredmény: {nyertes.Eredmeny}");
        }

        private static void Feladat06()
        {
            int auto = _versenyzok
                .Count(v => v.Dobasok[0] > 78 || v.Dobasok[1] > 78);

            Console.WriteLine("6. feladat: " +
                $"78.00 méter feletti eredménnyel továbbjutott: {auto} fő");
        }

        private static void Feladat05()
        {
            Console.WriteLine("5. feladat: " +
                $"Versenyzők száma a selejtezőben: {_versenyzok.Count} fő");
        }

        private static void Feladat04()
        {
            using (var sr = new StreamReader(
                path: "..\\..\\src\\Selejtezo2012.txt",
                encoding: Encoding.UTF8))
            {
                _ = sr.ReadLine();

                while (!sr.EndOfStream)
                    _versenyzok.Add(new Versenyzo(sr.ReadLine()));
            }
        }
    }
}
