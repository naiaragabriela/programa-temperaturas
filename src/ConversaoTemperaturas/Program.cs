double celsius, fahrenheit;

double TemperaturaDigitada()
{
    Console.Write("Digite um valor de temperatura em Graus Celcius: ");
    return double.Parse(Console.ReadLine());
}

celsius = TemperaturaDigitada();
 
void TemperaturaConvertida()
{
    fahrenheit = (((celsius * 9) / 5) + 32);
    Console.WriteLine($"A temperatura {celsius} ºC é convertida para {fahrenheit} ºF");
}
TemperaturaConvertida();