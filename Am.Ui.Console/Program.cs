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

Passenger passenger = new Passenger();
passenger.BirthDate = new DateTime(1990, 5, 1);
//passenger.GetAge1();
Console.WriteLine(passenger.Age);
/*
int age = 0;
Passenger passenger1 = new Passenger();
passenger.GetAge2(new DateTime(1990, 5, 1), ref age);
Console.WriteLine(age);*/


Passenger passenger2 = new Passenger();
Passenger Staff2 = new Staff();
Passenger Traveller2 = new Traveller();

Console.WriteLine(passenger2.GetPassengerType());
Console.WriteLine(Staff2.GetPassengerType());
Console.WriteLine(Traveller2.GetPassengerType());

Passenger passenger3 = new Passenger();
int calculateAge = 5;
//passenger3.GetAge(new DateTime(2000, 1, 1),ref calculateAge);
Console.WriteLine(calculateAge);
passenger3.BirthDate = new DateTime(2000,1,1);
//passenger3.GetAge(passenger3);
Console.WriteLine(passenger3.Age);
