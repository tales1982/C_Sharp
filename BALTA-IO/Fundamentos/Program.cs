// See https://aka.ms/new-console-template for more information
using System;


//Tipo de valor:
bool isTrue = true;
byte b = 200;
sbyte s = -50;
short n = -123;
ushort nn = 123;
int valor = -42;
uint age = 42;
long kmrestantes = -8500000000000000000;
ulong totalPecorridos = 6000000000000000000;
float pi = 3.14f;
double presicao = 3.14159265358979323846264;
decimal altaprecisao = 19.9999888877776600m;
char a = 'A';

Console.WriteLine("________________________________________________");
Console.WriteLine("___      Visualizacao de tipos simples       ___\n");

Console.WriteLine("bool     :" + isTrue);
Console.WriteLine("byte     :" + b);
Console.WriteLine("sbyte    :" + s);
Console.WriteLine("short    :" + n);
Console.WriteLine("ushort   :" + nn);
Console.WriteLine("int      :" + valor);
Console.WriteLine("uint     :" + age);
Console.WriteLine("long     :" + kmrestantes);
Console.WriteLine("ulong    :" + totalPecorridos);
Console.WriteLine("float    :" + pi);
Console.WriteLine("double   :" + presicao);
Console.WriteLine("decimal  :" + altaprecisao);
Console.WriteLine("char     :" + a);

Console.WriteLine("________________________________________________");
Console.WriteLine("___                  Enum                    ___\n");

Colors myColor = Colors.Blue;
Console.WriteLine(myColor);

Console.WriteLine("________________________________________________");
Console.WriteLine("___                  Struct                  ___\n");

// inicializa antes de usar
var p = new Pesson { Nome = "Tales", Idade = 42, Registrado = true };

string nome = p.Nome;
Console.WriteLine($"Nome: {nome}, Idade: {p.Idade}, Registrado: {p.Registrado}");

// ↓↓↓ TIPOS/ENUMS/STRUCTS após os top-level statements ↓↓↓
enum Colors { Red, Blue }

struct Pesson
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public bool Registrado { get; set; }
}