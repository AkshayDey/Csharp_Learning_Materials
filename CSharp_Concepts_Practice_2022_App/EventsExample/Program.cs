using EventsExample;

Engine aEngine = new Engine();

aEngine.Overheat += WhenOverHeat;
aEngine.Overheat += ShutDownEngine;

aEngine.SpeedUp(40);


void WhenOverHeat(int _heat)
{
    Console.WriteLine("Overheat :: {0}", _heat );
}

void ShutDownEngine(int _heat)
{
    if (_heat >= 500 && _heat <= 800)
    {
        aEngine.Stop();
    }
}