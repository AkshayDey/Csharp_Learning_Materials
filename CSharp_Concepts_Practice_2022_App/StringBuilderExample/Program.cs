using System.Text;

string text = "Hello there";
//text = text + " C#";   // it didn't modified the text string it created a new string object

//Console.WriteLine(text);

// we will now use stringBuilder


StringBuilder sbNew = new StringBuilder();
sbNew.AppendLine(text + " C#");


StringBuilder sb = new StringBuilder(text);
//sb.Append(text);
sb.AppendLine(" From C#");
sb.Append("From .net 6.0");
sb.Replace("World", "C#");

Console.WriteLine(sb); 