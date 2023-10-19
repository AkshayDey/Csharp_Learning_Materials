
using OOPPrincipleExample.Abstraction;


Teacher aTeacher = new Teacher();
aTeacher.Name = "dsdf";
aTeacher.Age = 23;

//Teacher bTeacher = new Teacher();
//bTeacher.Name = "sSas";
//bTeacher.Age = 25;

//Car aCar =  new Car();
//aCar.numbers = 10;
//aCar.AddSystem();


Membership aMembership = new Membership();
Consultant aConsultant =  new Consultant();
aMembership.GetMemberShipId(aTeacher);
aMembership.GetMemberShipId(aConsultant);
