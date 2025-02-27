using AutoZuSchnell;

List<Auto> cars = new List<Auto>()
{
    new Auto ("WI1216", 50),
    new Auto ("ZE7134", 100),
    new Auto ("ZE7135", 120),
    new Auto ("ZE7136", 130),
};

var autozuschnell = from car in cars
                    where car.Geschwindigkeit > 100
                    select car;

foreach (Auto auto in autozuschnell)
{
    Console.WriteLine(auto);
}
