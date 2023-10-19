

using GenericsExample;

Point<int, double> aPoint = new Point<int, double>();

aPoint.X = 132;
aPoint.Y = 23.34;

SuperPoint<double, int, int> aSuperPoint =  new SuperPoint<double, int, int>();
aSuperPoint.X = 2300.232;
aSuperPoint.Y = 232;

SecuritySystem <Person> aSecuritySystem =  new SecuritySystem<Person>();

aSecuritySystem.Open<string>("hello");