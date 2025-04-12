int numeroAtual = 0, proximoNumero = 1, QtdElementos, i, soma;

Console.Write("Quantidade de elementos: ");
QtdElementos = int.Parse(Console.ReadLine()!);

if (QtdElementos == 1){
    Console.WriteLine(numeroAtual);
}
else{
    for(i = 1; i <= QtdElementos; i++){
        
        soma = numeroAtual + proximoNumero;
        Console.WriteLine(numeroAtual);
        
        numeroAtual = proximoNumero;
        proximoNumero = soma;
        
        }
}

