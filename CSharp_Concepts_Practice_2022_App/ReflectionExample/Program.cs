using ReflectionExample;
using System.Reflection;

Car aCar = new Car("Toyota");
aCar.Start();
aCar.Stop();

Type t = typeof(Car);
Type t2 = aCar.GetType();

ConstructorInfo constInfo = t.GetConstructor(new Type[] { typeof(string)});
object item = constInfo.Invoke(new object[] { "Nissan"});
MethodInfo  m = t.GetMethod("Start", BindingFlags.Instance | BindingFlags.Public );
m.Invoke(item, new object[] { });
MethodInfo m2 = t.GetMethod("Stop", BindingFlags.Instance | BindingFlags.Public);
m2.Invoke(item, new object[] { });