using AbstractFactoryDesignPattern;

// For Fighter Mig29
FighterFactory fighterFactoryForMig = new Mig29Factory();
Fighter fighterMig29 = fighterFactoryForMig.CreateFighter();
fighterMig29.Weapon = fighterFactoryForMig.CreateWeapon();

Console.WriteLine(fighterMig29);
Console.WriteLine(fighterMig29.Weapon);

// For Fighter F16
FighterFactory fighterFactoryForF16 = new F16Factory();
Fighter fighterF16 =  fighterFactoryForF16.CreateFighter();
fighterF16.Weapon= fighterFactoryForF16.CreateWeapon();

Console.WriteLine(fighterF16);
Console.WriteLine(fighterF16.Weapon);


