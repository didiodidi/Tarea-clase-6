


Console.WriteLine("Ingrese un valor");
int nuevoValor = Int32.Parse(Console.ReadLine ());

Random numero = new Random();
int numeroSecreto = numero.Next(0, 21);

int intentos = 0;

while(nuevoValor != numeroSecreto ){
    if(nuevoValor < numeroSecreto){
        Console.WriteLine("Debes ingresar un numero mayor");
        nuevoValor = int.Parse(Console.ReadLine ());
    }
    else if (nuevoValor > numeroSecreto){
        Console.WriteLine("Debes ingresar un numero menor");
        nuevoValor = int.Parse(Console.ReadLine ());
    }
    intentos++; 
}
Console.WriteLine("Felicidades!! Adivinaste el numero!!");
Console.WriteLine($"Tu numero de intentos es : {intentos}");

