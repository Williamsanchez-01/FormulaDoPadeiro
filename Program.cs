Console.Clear();


Console.WriteLine("Receita do padeiro para pão italiano\n");


double farinha = 1;
double agua = 0.7;
double fermento = 0.4;
double sal = 0.02;


double soma = farinha+agua+fermento+sal;


Console.Write("Digite a quantidade de farinha que você deseja utilizar: ");


double peso = Convert.ToDouble(Console.ReadLine());


double qtfarinha =  peso/soma;


double a = qtfarinha*agua;
double fe = qtfarinha*fermento;
double s =  qtfarinha*sal;


Console.WriteLine($"Peso desejado de pão Italiano (em gramas).....: {peso}\n");
Console.WriteLine($"Farinha: {qtfarinha:N0}");
Console.WriteLine($"Agua: {a:N0}");
Console.WriteLine($"Fermento: {fe:N0}");
Console.WriteLine($"Sal: {s:N0}");
