// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LABORATORIO.Consuelo_Gloribel_Castro_Alberto.Entidades.Negocio;
using LABORATORIO.Consuelo_Gloribel_Castro_Alberto.Entidades;

ClsPersona Clspersona = new ClsPersona();
Persona persona = new Persona();

Console.WriteLine("Bienvenido/a");
Console.WriteLine("Ingresar su Nombre: ");
persona.nombre = (Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Ingresar  su edad: ");
persona.edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Ingresar su Sexo: ");
persona.sexo = (Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Ingresar su Peso: ");
persona.peso = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Ingresar su Altura: ");
persona.altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ");

Clspersona.PesodePersonas(persona);


Console.WriteLine(" ");

Clspersona.MayordeEdad(persona);


Console.ReadKey();
