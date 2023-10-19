using InterfaceExample;


#region oldCode
//IEngine aTurboEngine = new TurboEngine(12.323);

//Console.WriteLine(aTurboEngine.GetSpeed());

//TurboEngine bTurboEngine = new TurboEngine(567);
//bTurboEngine.Start();

//FifthEngine aFifthEngine = new FifthEngine();
//aFifthEngine.Start();

//bTurboEngine.IncreaseSpeed(10);
//aFifthEngine.IncreaseSpeed(100);

//SixthGenEngine aSixthGenEngine = new SixthGenEngine();
//aSixthGenEngine.IncreaseSpeed(12);
#endregion

#region newCode 07_Nov_2022

//ImplementationInterface2 aInterfaceTwo = new ImplementationInterface2();
//aInterfaceTwo.Add(12,23);
//aInterfaceTwo.Sub(23, 22);

IInterface2 interface2obj = new ImplementationInterface2();
interface2obj.Add(12, 23);
interface2obj.Sub(100, 230);

#endregion