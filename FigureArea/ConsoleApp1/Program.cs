
using Application;
using FigureArea.Models;

var service = new FigureService();

var triangle = Triangle.Create(4, 1, 2);

Console.WriteLine(service.GetArea(triangle));
