// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string ClassTopic = "Metodos de Strings";
string school = "Platzi";

Console.WriteLine("Estoy aprendiendo " + ClassTopic + " en " + school);

/* Clone */
string schoolClone = school.Clone().ToString();
Console.WriteLine(schoolClone);

/* CompareTo */
Console.WriteLine("ClastTopic es igual a school: " + (ClassTopic.CompareTo(school)));
Console.WriteLine("School es igual a SchoolClone: " + (school.CompareTo(schoolClone)));

/* Contains */
Console.WriteLine("School contiene \"Pla\": " + school.Contains("Pla"));

/* EndsWith */
Console.WriteLine("School termina en \"zi\": " + school.EndsWith("zi"));

/* Starts with */
Console.WriteLine("School empieza con \"Pl\": " + school.StartsWith("Pl"));

/* Equals */
Console.WriteLine("School es igual a schoolClone: " + school.Equals(schoolClone));

/* IndexOf */
Console.WriteLine("School, indice del caracter \"a\": " + school.IndexOf("a"));

/* ToUpper y ToLower*/
Console.WriteLine("Mayusculas" + school.ToUpper());
Console.WriteLine("Minusculas" + school.ToLower());

/* Insert */
Console.WriteLine(school.Insert(6, " Es educación online efectiva"));

/* LastIndexOf */
Console.WriteLine(ClassTopic.LastIndexOf("s"));

/* Remove */
Console.WriteLine(school.Remove(3));

/* Replace */
Console.WriteLine(school.Replace("t", "d"));

/* Split */
string[] split = ClassTopic.Split(new char[] { 's' });

Console.WriteLine(split[0]);
Console.WriteLine(split[1]);
Console.WriteLine(split[2]);
//Console.WriteLine(split[3]);

/* Substring */
Console.WriteLine(ClassTopic.Substring(3,5));

/* ToCharAray */
school.ToCharArray();
Console.WriteLine(school[0]);
Console.WriteLine(school[1]);
Console.WriteLine(school[2]);

/* Trim */
string textWithSpaces = "                  Hola, esto es para una prubea del metodo trim                  ";
Console.WriteLine(textWithSpaces.Trim());






