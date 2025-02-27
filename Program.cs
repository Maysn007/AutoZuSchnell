using AutoZuSchnell;

List<Auto> cars = new List<Auto>()
{
    new Auto ("BMW", "ZE BERN1", 100),
    new Auto ("Audi" ,"ZE 99GO", 80),
    new Auto ("Mercedes", "ZE 343FK", 30),
    new Auto ("VW" ,"ZE 800KM", 130),
};

var autozuschnell = from car in cars
                    where car.Geschwindigkeit > 70
                    select car;

foreach (Auto auto in autozuschnell)
{
    Console.WriteLine(auto);
}
