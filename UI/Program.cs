using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var context = new EFOpleidingenContext();
            ////foreach (var docent in context.Docenten)
            ////    Console.WriteLine(docent.Naam);
            ////Console.WriteLine(context.Docenten.ToQueryString());
            //Console.Write("Minimum wedde:");
            ////if (decimal.TryParse(Console.ReadLine(), out decimal minWedde))
            ////{
            ////    //var query = from docent in context.Docenten
            ////    //            where docent.Wedde >= minWedde
            ////    //            orderby docent.Voornaam, docent.Familienaam
            ////    //            select docent;
            ////    var query = context.Docenten
            ////        .Where(docent => docent.Wedde >= minWedde)
            ////        .OrderBy(docent => docent.Voornaam)
            ////        .ThenBy(docent => docent.Familienaam);
            ////    foreach (var docent in query)
            ////        Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);
            ////}
            ////else
            ////    Console.WriteLine("Geef een getal in !");
            //if(decimal.TryParse(Console.ReadLine(), out decimal minWedde))
            //{
            //    Console.Write("Sorteren:1=op wedde, 2=op familienaam, 3=op voornaam:");
            //    var sorterenOp = Console.ReadLine();
            //    //IQueryable<Docent> query; //LINQ
            //    Func<Docent, Object> sorteerLambda; //query method
            //    switch (sorterenOp)
            //    {
            //        case "1":
            //            //query = from docent in context.Docenten
            //            //        where docent.Wedde >= minWedde
            //            //        orderby docent.Wedde
            //            //        select docent;//LINQ
            //            sorteerLambda = (docent) => docent.Wedde;//query method
            //            break;
            //        case "2":
            //            //query = from docent in context.Docenten
            //            //        where docent.Wedde >= minWedde
            //            //        orderby docent.Familienaam
            //            //        select docent;//LINQ
            //            sorteerLambda = (docent) => docent.Familienaam;//query method
            //            break;
            //        case "3":
            //            //query = from docent in context.Docenten
            //            //        where docent.Wedde >= minWedde
            //            //        orderby docent.Voornaam
            //            //        select docent;//LINQ
            //            sorteerLambda = (docent) => docent.Voornaam;//query method
            //            break;
            //        default:
            //            Console.WriteLine("Verkeerde keuze");
            //            //query = null;//LINQ
            //            sorteerLambda = null;//query method
            //            break;
            //    }
            //    //if (query != null)
            //    //    foreach (var docent in query)
            //    //        Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);//LINQ
            //    if (sorteerLambda != null)
            //    {
            //        var query = context.Docenten
            //            .Where(d => d.Wedde >= minWedde)
            //            .OrderBy(sorteerLambda);
            //        foreach (var docent in query)
            //            Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);//query method
            //    }
            //    else
            //        Console.WriteLine("U tikte geen getal");
            //}

            //Console.Write("DocentNr.:");
            //if (int.TryParse(Console.ReadLine(), out int docentNr))
            //{
            //    var docent = context.Docenten.Find(docentNr);
            //    Console.WriteLine(docent == null ? "Niet Gevonden" : docent.Naam);//true:false
            //}
            //else
            //    Console.WriteLine("U tikte geen getal");

            //LINQ
            //var query = from campus in context.Campussen
            //            orderby campus.Naam
            //            select new { campus.CampusId, campus.Naam };
            //QUERY METHOD
            //var query = context.Campussen
            //    .OrderBy(c => c.Naam)
            //    .Select(c => new { c.CampusId, c.Naam });

            //Console.WriteLine(query.ToQueryString());
            //foreach (var campusDeel in query)
            //    Console.WriteLine("{0}: {1}", campusDeel.CampusId, campusDeel.Naam);

            //var query = from docent in context.Docenten
            //            group docent by docent.Voornaam
            //            into voornaamGroep
            //            select new
            //            {
            //                Voornaam = voornaamGroep.Key,
            //                Aantal = voornaamGroep.Count()
            //            };
            //foreach(var voornaamStatistiek in query)
            //{
            //    //Console.Write(voornaamStatistiek.Voornaam + ": ");
            //    //Console.WriteLine(voornaamStatistiek.Aantal + " keer.");
            //    Console.WriteLine($"{voornaamStatistiek.Voornaam}: {voornaamStatistiek.Aantal} keer.");
            //}

            //Console.Write("Voornaam:");
            //var voornaam = Console.ReadLine();
            //var query = from docent in context.Docenten
            //            where docent.Voornaam == voornaam
            //            select docent;
            //foreach (var docent in query)
            //    Console.WriteLine("{0}: {1}", docent.Naam, docent.Campus.Naam);

            //Console.Write("Voornaam:");
            //var voornaam = Console.ReadLine();
            //var query = from docent in context.Docenten.Include("Campus")
            //            where docent.Voornaam == voornaam
            //            select docent;
            //foreach (var docent in query)
            //    Console.WriteLine("{0}: {1}", docent.Naam, docent.Campus.Naam);

            //Console.Write("Geef (een deel van) de naam van de campus:");
            //var deelNaam = Console.ReadLine();
            ////var query = from campus in context.Campussen.Include("Docenten")
            ////            where campus.Naam.Contains(deelNaam)
            ////            orderby campus.Naam
            ////            select campus; //LINQ
            //var query = context.Campussen.Include("Docenten")
            //    .Where(x => x.Naam.Contains(deelNaam))
            //    .OrderBy(x => x.Naam); //QUERY METHOD

            //foreach(var campus in query)
            //{
            //    var campusNaam = campus.Naam;
            //    Console.WriteLine(campusNaam);
            //    Console.WriteLine(new string('-', campusNaam.Length));
            //    foreach (var docent in campus.Docenten)
            //        Console.WriteLine(docent.Naam);
            //    Console.WriteLine();
            //}

            //TOLIST
            //List<Campus> campussen;
            //var query = from campus in context.Campussen
            //            orderby campus.Naam
            //            select campus;
            //campussen = query.ToList();
            //foreach (var campus in campussen)
            //    Console.WriteLine(campus.Naam);
            //Console.WriteLine();
            //foreach (var campus in campussen)
            //    Console.WriteLine(campus.Naam);//no new sql is executed to find the names

            //TOLIST IN A SINGLE METHOD

            //foreach (var campus in FindAllCampussen())
            //    Console.WriteLine(campus.Naam);

            //static List<Campus> FindAllCampussen()
            //{
            //    using var context = new EFOpleidingenContext();
            //    return (from campus in context.Campussen
            //            orderby campus.Naam
            //            select campus).ToList();
            //}

            //var campus = new Campus
            //{
            //    Naam = "Campus01",
            //    Straat = "Straat01",
            //    Huisnummer = "01",
            //    Postcode = "0101",
            //    Gemeente = "Gemeente01"
            //};
            //context.Campussen.Add(campus);
            //context.SaveChanges();
            //Console.WriteLine(campus.CampusId);
            //var campus2 = new Campus
            //{
            //    Naam = "Campus02",
            //    Straat = "Straat02",
            //    Huisnummer = "2",
            //    Postcode = "2222",
            //    Gemeente = "Gemeente02"
            //};
            //var campus3 = new Campus
            //{
            //    Naam = "Campus03",
            //    Straat = "Straat03",
            //    Huisnummer = "3",
            //    Postcode = "3333",
            //    Gemeente = "Gemeente03"
            //};
            //var campus4 = new Campus
            //{
            //    Naam = "Campus04",
            //    Straat = "Straat04",
            //    Huisnummer = "4",
            //    Postcode = "4444",
            //    Gemeente = "Gemeente04"
            //};
            //var campus5 = new Campus
            //{
            //    Naam = "Campus05",
            //    Straat = "Straat05",
            //    Huisnummer = "5",
            //    Postcode = "5555",
            //    Gemeente = "Gemeente05"
            //};
            //context.Campussen.AddRange(campus2, campus3);
            //context.Campussen.AddRange(new List<Campus> { campus4, campus5 });
            //context.SaveChanges();

            // var campus6 = new Campus
            // {
            //     Naam = "Campus06",
            //     Straat = "Straat06",
            //     Huisnummer = "6",
            //     Postcode = "6666",
            //     Gemeente = "Gemeente06"
            // };
            // var docent1 = new Docent
            // {
            //     Familienaam = "Docent01",
            //     Voornaam = "Voornaam01",
            //     Wedde = 1111,
            //     CampusId = 1
            // };

            // context.AddRange(campus6, docent1); 
            //context.SaveChanges();

            //var campus7 = new Campus
            //{
            //    Naam = "Campus07",
            //    Straat = "Straat07",
            //    Huisnummer = "7",
            //    Postcode = "7777",
            //    Gemeente = "Gemeente07"
            //};
            //var docent2 = new Docent
            //{
            //    Voornaam = "Voornaam02",
            //    Familienaam = "Docent02",
            //    Wedde = 2222
            //};
            //campus7.Docenten.Add(docent2); 

            //context.Campussen.Add(campus7);
            //context.SaveChanges();

            //var campus8 = new Campus
            //{
            //    Naam = "Campus08",
            //    Straat = "Straat08",
            //    Huisnummer = "8",
            //    Postcode = "8888",
            //    Gemeente = "Gemeente08"
            //};
            //var docent3 = new Docent
            //{
            //    Voornaam = "Voornaam03",
            //    Familienaam = "Docent03",
            //    Wedde = 3333
            //};
            //docent3.Campus = campus8;

            //context.Docenten.Add(docent3);
            //context.SaveChanges();

            //var docent4 = new Docent
            //{
            //    Voornaam = "Voornaam04",
            //    Familienaam = "Docent04",
            //    Wedde = 4444
            //};
            //var campus1 = context.Campussen.Find(1);
            //if (campus1 != null)
            //{
            //    context.Docenten.Add(docent4);
            //    docent4.Campus = campus1;
            //    context.SaveChanges();
            //}
            //else
            //    Console.WriteLine("Campus 1 niet gveonden");
            //var docent5 = new Docent
            //{
            //    Voornaam = "Voornaam05",
            //    Familienaam = "Docent05",
            //    Wedde = 5555,
            //    CampusId = 1
            //};
            //context.Docenten.Add(docent5);
            //context.SaveChanges();
            //var docent = new Docent
            //{
            //    Voornaam = "Voornaam06",
            //    Familienaam = "Docent06",
            //    Wedde = 6666
            //};
            //var campus = context.Campussen.Find(1);
            //if (campus != null)
            //{
            //    campus.Docenten.Add(docent);
            //    context.SaveChanges();
            //}
            //else
            //    Console.WriteLine("Campus 1 niet geveonden");

            //Console.WriteLine("DocentNr.:");
            //if (int.TryParse(Console.ReadLine(), out int docentNr))
            //{
            //    var docent = context.Docenten.Find(docentNr);
            //    if (docent is not null)
            //    {
            //        Console.WriteLine($"Wedde: {docent.Wedde}");
            //        Console.Write("Bedrag?");
            //        if (decimal.TryParse(Console.ReadLine(), out decimal bedrag))
            //        {
            //            docent.Opslag(bedrag);
            //            context.SaveChanges();
            //        }
            //        else
            //            Console.WriteLine("Tik een getal in");
            //    }
            //    else
            //        Console.WriteLine("Docent neit gevonedne");
            //}
            //else
            //    Console.WriteLine("Tik een getal in ");

            //Console.Write("Bovengrens:");
            //if (int.TryParse(Console.ReadLine(), out int grens))
            //{
            //    foreach (var docent in context.Docenten)
            //        if (docent.Wedde <= grens) docent.Opslag(100m);
            //    context.SaveChanges();
            //}
            //else
            //    Console.Write("Tik een getal");

            //var campus1 = context.Campussen.Include("Docenten")
            //    .FirstOrDefault(c => c.CampusId == 1);//alle docenten van campus1 krijgen opslag
            //if (campus1 != null)
            //{
            //    foreach (var docent in campus1.Docenten)
            //        docent.Opslag(10M);
            //    context.SaveChanges();
            //}

            //var docent1 = context.Docenten.Find(1);
            //if (docent1 is not null)
            //{
            //    var campus6 = context.Campussen.Find(6);
            //    if (campus6 is not null)
            //    {
            //        docent1.Campus = campus6;
            //        context.SaveChanges();
            //    }
            //    else
            //        Console.WriteLine("Campus 6 niet gevonden");
            //}
            //else
            //    Console.WriteLine("Docent 1 niet gevonedn");

            //var docent1 = context.Docenten.Find(1);
            //if (docent1 is not null)
            //{
            //    var campus3 = context.Campussen.Find(3);
            //    if (campus3 is not null)
            //    {
            //        campus3.Docenten.Add(docent1);
            //        context.SaveChanges();
            //    }
            //    else
            //        Console.WriteLine("campus 3 niet gevoneden");
            //}
            //else
            //    Console.WriteLine("docent 1 niet gevonedn");

            //Console.Write("nummer docent");
            //if (int.TryParse(Console.ReadLine(), out int docentNr))
            //{
            //    var docent = context.Docenten.Find(docentNr);
            //    if (docent != null)
            //    {
            //        context.Docenten.Remove(docent);
            //        context.SaveChanges();
            //    }
            //    else Console.WriteLine("Docent niet gevonden");
            //}
            //else Console.WriteLine("tik een getal");

            //context.TPHCursussen.Add(new TPHKlassikaleCursus
            //{
            //    Naam = "frans in 24u",
            //    Van = DateTime.Today,
            //    Tot = DateTime.Today
            //});
            //context.TPHCursussen.Add(new TPHZelfstudieCursus
            //{
            //    Naam = "engels in 24u",
            //    AantalDagen = 1
            //});
            //context.SaveChanges();
            context.TPTCursussen.Add(new TPTKlassikaleCursus
            {
                Naam = "frans in 24 uur",
                Van = DateTime.Today,
                Tot = DateTime.Today
            });
            context.TPTCursussen.Add(new TPTZelfstudieCursus
            {
                Naam = "engels in 24 uur",
                AantalDagen = 1
            });
            context.SaveChanges();


        }
    }
}
