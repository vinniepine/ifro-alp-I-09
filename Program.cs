/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica de Programação I
 * Professor Clayton Ferraz Andrade
 *
 * Acadêmico Vinícius de Oliveira Pinheiro
 * Aula do dia 17-05-2023
 */

// Escrevendo strings sem precisar utilizar '\n' para saltar linhas
Console.WriteLine(@"Começa assim...





termina assim.");

// Operador ternáio:
int grade = 7;
if(grade >= 6)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

// Abaixo está uma outra maneira de fazer o mesmo que escrito acima.
Console.WriteLine(grade >= 8? "Aprovado!" : "Reprovado!");

// Também há da seguinte maneira:
string result = grade >= 8? "Aprovado!" : "Reprovado!";
Console.WriteLine(result);

// Pedindo a raiz de um número:
Math.Pow(3, 5); // é o mesmo que 3**5 
Math.Sqrt(16); // é o mesmo que 16**(1/2)

// Mostrando a data
Console.ForegroundColor = ConsoleColor.DarkCyan;  // muda a cor da letra;
Console.BackgroundColor = ConsoleColor.Black; // muda a cor do fundo;
