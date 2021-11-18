

using IsacMinuter;

Console.WriteLine("Om hur många minuter sa Isac att han var klar?");

IsacMinutos isacMinuter = new IsacMinutos();

string input = Console.ReadLine();

double Isacminuter = Double.Parse(input);

Isacminuter = isacMinuter.HurMångaMinuterSaHan(Isacminuter);

Console.WriteLine(Isacminuter);

