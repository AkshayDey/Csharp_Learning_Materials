
using System.Reflection;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Security.AccessControl;
using Newtonsoft.Json;

//Assembly a;
//Type t;

//object o;
////o.GetType();

//Type t2 = typeof(int);

//Type t3 = (3).GetType();
//Console.WriteLine(t2.Name);
//Console.WriteLine(t3.FullName);

//a.GetTypes();// returns all the types


DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory())
                         .Parent.Parent.Parent;
string config = File.ReadAllText(directory.GetFiles().Where(x => x.Name.Contains("config")).First().FullName);


dynamic configJson = JsonConvert.DeserializeObject(config);

//Type t = Assembly.GetExecutingAssembly().GetTypes()
//        .Where(x => x.Name == configJson.ClassName.ToString()
//         && x.GetInterface("IPlugin") != null).First();


//Type t = Assembly.GetExecutingAssembly().GetTypes()
//        .Where(x => x.Name == configJson.ClassName.ToString()).First();

Type t = Assembly.LoadFile(directory.Parent.GetFiles().Where(x => x.Extension == ".dll").First().FullName).GetTypes()
        .Where(x => x.Name == configJson.ClassName.ToString()).First();

ConstructorInfo constructor = t?.GetConstructor(new Type[] { typeof(string)});
object o = constructor?.Invoke(new object[] { "Demo Report" });
MethodInfo method = t?.GetMethod("Start", new Type[] { });
method?.Invoke(o, new object[] { });
//Console.WriteLine(t.Name);
