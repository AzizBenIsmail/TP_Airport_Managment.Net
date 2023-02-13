// See https://aka.ms/new-console-template for more information

//using System.Numerics;

using Am.core.Domaine;
//TP1.Q7
Console.WriteLine("Hello, World!");
Plane plane= new Plane();
plane.Capacity= 100;
plane.ManufactureDate= new DateTime(2000,1,1);
plane.MyPlaneType = PlaneType.Boeing;

//TP1.Q8 (on utilise ce methode quand il y a des proprietes obligatoires
Plane plane2 = new Plane(PlaneType.Boeing, 100, new DateTime(2000,1,1));

//TP1.Q9 construire le constructore et l'initialiser (initialiseur d'objet) - plus dynamique
Plane plane3 = new Plane()
{
    Capacity = 100,
    ManufactureDate = new DateTime(2000,1,1),
    MyPlaneType= PlaneType.Boeing
};