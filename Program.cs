//Solicite ao usuário que digite a sua senha (uma string). Exiba "Acesso permitido" caso a senha digitada seja 1234abcd, senão exiba "Acesso negado".

Console.Clear();
string senha;
 
Console.Write("Olá, usuário. Por favor, digite sua senha: ");
senha = Convert.ToString(Console.ReadLine())!;
 
if (senha != Convert.ToString("1234abcd"))
{
    Console.WriteLine("Acesso negado");
}
else
{
    Console.WriteLine("Acesso permitido");
}