using RecordsExample;

// Record checks the data equality not the reference equality like class


Person aPerson  =  new Person();
aPerson.Name = "A";
aPerson.Age = 23;

Person bPerson = CreateNewPerson();

Person CreateNewPerson()
{
    return new Person();
}

bPerson.Name = "C";
bPerson.Age = 23;

if(aPerson == bPerson)
{
    Console.WriteLine("Same");                           
}
