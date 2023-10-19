using ConceptualBuilderDesignPattern;

Director aDirector = new Director();
ConcreteBuilder aConcreteBuilder = new ConcreteBuilder();
aDirector.Builder= aConcreteBuilder;

Console.WriteLine("Standard Basic product:");
aDirector.BuildMinimalViableProduct();
Console.WriteLine(aConcreteBuilder.GetProduct().ListParts());