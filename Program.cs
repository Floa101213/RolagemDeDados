using System.Security.Cryptography;

int faces, sorteado;

Console.WriteLine("---Rolagem de Dado---\n");

Console.WriteLine("quantas faces ?");
faces = Convert.ToInt32(Console.ReadLine());

sorteado = RandomNumberGenerator.GetInt32(1, faces + 1);

Console.WriteLine($"\nRolagem: {sorteado}");
