
var ay = DateTime.Now.Month;
string ayad;
switch (ay)
{
    case 1:
        ayad = "Ocak";
        break;
    case 2:
        ayad = "Şubat";
        break;
    case 3:
        ayad = "Mart";
        break;
    case 4:
        ayad = "Nisan";
        break;
    case 5:
        ayad = "Mayıs";
        break;
    default:
        ayad = "Diğer Aylar";
        break;
}
Console.WriteLine("Şimdi " + ayad + " ayında bulunuyorsunuz.");
