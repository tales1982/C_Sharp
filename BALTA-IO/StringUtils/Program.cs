using System;

Console.WriteLine("======================== GUID ========================");
Guid id = Guid.NewGuid();
Console.WriteLine("My Guid Id : " + id);
Console.WriteLine();
Console.WriteLine("=================== String.Format ====================");
DateTime agora = DateTime.Now;
string texto = string.Format("Hoje é {0:dd/MM/yyyy} e agora são {0:HH:mm}", agora);
Console.WriteLine(texto);
Console.WriteLine();
Console.WriteLine("====================== CompareTo ======================");
int A = 10;
int B = 20;

if (B.CompareTo(A) == 1) Console.WriteLine($"B e MAIOR que A RETORNO[{B.CompareTo(A)}]");
if (A.CompareTo(B) == -1) Console.WriteLine($"A e MENOS que B RETORNO[{A.CompareTo(B)}]");
if (A.CompareTo(10) == 0) Console.WriteLine($"A e IGUAL a 10 RETORNO[{A.CompareTo(10)}]");
Console.WriteLine();
Console.WriteLine("====================== Contains ======================");
string tales = "Tales lima de paula";
string buscarNome = "tales";
bool temTales = tales.Contains(buscarNome);

Console.WriteLine("Nome original : " + tales);

if (temTales == true) Console.WriteLine($"A palavra {buscarNome} exister na frase");
else Console.WriteLine($"A palavra {buscarNome} nao exister na frase.");


bool temTales2 = tales.Contains(buscarNome, StringComparison.OrdinalIgnoreCase);//ignora letraMaiuscula
if (temTales2 == true) Console.WriteLine($"A palavra {buscarNome} exister na frase ignorando letras maiuscula e minuscula");
else Console.WriteLine($"A palavra {buscarNome} nao exister na frase.");
Console.WriteLine();
Console.WriteLine("====================== StartWhit ======================");
string theo = "Theo de Paula";
string buscaTheo = "Theo";

bool acheiFrase = theo.StartsWith(buscaTheo);
Console.WriteLine($"Nome original {theo}");
if (acheiFrase == true) Console.WriteLine($"Achei o texto {buscaTheo}");
else Console.WriteLine($"Nao achei o texto {buscaTheo}");
Console.WriteLine();
Console.WriteLine("====================== EndtWhit ======================");
string thomas = "Thomas de Paula";
string buscaThomas = "Paula";

bool acheiFrase2 = thomas.EndsWith(buscaThomas);
Console.WriteLine($"Nome original {thomas}");
if (acheiFrase2 == true) Console.WriteLine($"Achei o texto {buscaThomas}");
else Console.WriteLine($"Nao achei o texto {buscaThomas}");
Console.WriteLine();

Console.WriteLine("====================== Equals ======================");
string s1 = "Ola mundo";
string s2 = "Ola mundo";

string s3 = "ola mundo2";

Console.WriteLine("Original : " + s1);
bool isEqual1 = s1.Equals(s2);
if (isEqual1 == true) Console.WriteLine($"A frase {s1} igual a {s2}.");
else Console.WriteLine($"A frase {s1} nao e igual a {s2}.");

bool isEqual2 = s1.Equals(s3);
if (isEqual2 == true) Console.WriteLine($"A frase {s1} igual a {s3}.");
else Console.WriteLine($"A frase {s1} nao e igual a {s3}.");

Console.WriteLine();
Console.WriteLine("===================== IndexOf ======================");
string buscarIndex = "Vamos fazer uma busca.";
char encontra = 'z';

Console.WriteLine("Texto original : " + buscarIndex);
Console.WriteLine($"A letra {encontra} foi encontrada no index[{buscarIndex.IndexOf(encontra)}] (primeira referencia encontrada)");
Console.WriteLine();

Console.WriteLine("===================== IndexOf ======================");
string buscarIndex2 = "Vamos fazer uma busca versao last index (z).";
char encontra2 = 'z';

Console.WriteLine("Texto original : " + buscarIndex2);
Console.WriteLine($"A letra {encontra2} foi encontrada no index[{buscarIndex2.LastIndexOf(encontra2)}] (primeira referencia encontrada)");
Console.WriteLine();

Console.WriteLine("===================== Insert ======================");
string nomeOriginal = "Theo lima";
string novoNome = nomeOriginal.Insert(9, " de Paula");

Console.WriteLine("Nome original : " + nomeOriginal);
Console.WriteLine($"Nome depois de editado: {novoNome}");
Console.WriteLine();

Console.WriteLine("===================== Remove ======================");
string nomeOriginal2 = "Theo lima de de paula";
string novoNome2 = nomeOriginal2.Remove(9, 3);

Console.WriteLine("Nome original : " + nomeOriginal2);
Console.WriteLine($"Nome depois de editado: {novoNome2}");
Console.WriteLine();

string cpf = "123.456.789-00";
Console.WriteLine("CPF original : " + cpf);
// Remove os pontos e o traço
cpf = cpf.Remove(3, 1).Remove(6, 1).Remove(9, 1);
Console.WriteLine("CPF alterado : " + cpf);
Console.WriteLine();

Console.WriteLine("===================== Replace ======================");
string frase = "Theo lima";
string novaFrase = frase.Replace("Theo", "Thomas");

Console.WriteLine("Nome original : " + frase);
Console.WriteLine($"Nome depois de editado: {novaFrase}");
Console.WriteLine();

string cpff = "123.456.789-00";
Console.WriteLine($"CPF ORIGINAL: {cpff}");
string limpo = cpff.Replace(".", "").Replace("-", "");
Console.WriteLine($"CPF EDITADO: " + limpo);
Console.WriteLine();

Console.WriteLine("===================== Split ======================");
string frase3 = "Ola tales tudo bem com voce.";

Console.WriteLine("Frase original : " + frase3);
Console.WriteLine();

Console.WriteLine("Frase usando o split : ");
string[] palavras = frase3.Split(' ');

foreach (string p in palavras)
{
    Console.WriteLine(p);
}

Console.WriteLine();
