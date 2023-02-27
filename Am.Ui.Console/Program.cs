// See https://aka.ms/new-console-template for more information
//using System.Numerics;

using AM.Core.Domain;
//TP1. Question 7
Console.WriteLine("Hello, World!");
Plane plane= new Plane();
plane.Capacity = 100;
plane.ManufactureDate = new DateTime(2000,1,1);
plane.MyPlaneType = PlaneType.BOING;

//TP1. Question 8  (on utilise ce methode quand il y a des proprietes obligatoires)
Plane plane2 = new Plane(PlaneType.BOING, 100, new DateTime(2000, 1, 1));

//TP1 Question 9 construire le constructore et l'initialiser (initialiseur d'objet) - plus dynamique
Plane plane3 = new Plane()
{
    Capacity= 100,
    ManufactureDate= new DateTime(2000, 1, 1),
    MyPlaneType= PlaneType.BOING
};

Passenger passenger = new Passenger();
passenger.BirthDate = new DateTime(1990, 5, 1);
//passenger.GetAge1();
Console.WriteLine(passenger.Age);


//tp1 question 12.b
Passenger passanger2 =new Passenger();
Passenger staff2= new Staff();
Passenger traveller2 = new Traveller();
Console.WriteLine(passanger2.GetPassengerType());
Console.WriteLine(staff2.GetPassengerType());
Console.WriteLine(traveller2.GetPassengerType());

//tp1 question 13.c
Passenger passenger3=new Passenger();
//int calculatedAge = 5;
//passenger3.GetAge(new DateTime(2000,1,1), ref calculatedAge);
//Console.WriteLine(calculatedAge);
passenger3.BirthDate = new DateTime(2000, 1, 1);
//passenger3.GetAge(passenger3);
Console.WriteLine(passenger3.Age);