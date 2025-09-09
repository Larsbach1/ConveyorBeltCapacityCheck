//ReadMe til "Conveyor belt Capacity Check"
//Dette program bruges til at beregne om kapaciteten af transportbåndets motorer kan håndtere den samlede vægt af pakker der modtages.

//Programmet er skrevt så det følger en fast opbygning.
    //1. "Hvor mange motorer er der til båndet?"
    //2. "Hvor mange kg. pakker er der?"
    //3. Beregner vægt pr. motor
    //4. Beslutning med if/else
    //5. Udskriver info om belastning pr. motor

//Programmet indeholder ikke kode der kan håndtere andre tegn end tal, men kan bruges til forskellige tegnsætning for decimaltal"," og ".".

using System;

class Program
{
    static void Main()
    {
        const double MotorKapacitet = 5.6;  // Konstant værdi (kg pr. motor)

        // Spørger brugeren hvor mange motorer
        Console.WriteLine("Hvor mange motorer er der til båndet?");
        int motorer = Convert.ToInt32(Console.ReadLine());

        // Spørger brugeren hvor mange kg pakker
        Console.WriteLine("Hvor mange kg. pakker er der?");
        double pakkeVægt = Convert.ToDouble(Console.ReadLine());

        // Beregner vægt pr. motor
        double vægtPerMotor = pakkeVægt / motorer;

        // Beslutning med if/else
        if (vægtPerMotor <= MotorKapacitet)
        {
            Console.WriteLine("Ja, transportbåndet kan håndtere vægten.");
        }
        else
        {
            Console.WriteLine("Nej, transportbåndet kan ikke håndtere vægten.");
        }

        // Udskriver info om belastning pr. motor
        Console.WriteLine($"Vægt pr. motor: {vægtPerMotor:F2} kg (Kapacitet: {MotorKapacitet} kg)");
    }
}