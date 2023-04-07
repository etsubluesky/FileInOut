// See https://aka.ms/new-console-template for more information
using FileInOut;

List<Student> students = new List<Student>();

char directorySep = Path.DirectorySeparatorChar;

var locationOfProject = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent;

Console.WriteLine(locationOfProject);

string locationOfFile = @$"{locationOfProject}{directorySep}Data{directorySep}InClass.csv";

StreamReader reader = new StreamReader(locationOfFile);


List<string> lines = new List<string>();

while(!reader.EndOfStream)
{
    lines.Add(reader.ReadLine());
    

}

for(int i = 1; i < lines.Count; i++)
{
    students.Add(new Student(lines[i].Split(',')[0], lines[i].Split(',')[1], lines[i].Split(',')[2], lines[i].Split(',')[3]));
}

var sortedList = students.OrderBy(l => l.FirstName).ToList();

foreach(Student student in sortedList)
{
    Console.WriteLine(student.ToCSV());
}

reader.Close();

/*
StreamWriter writer = new StreamWriter(locationOfProject + "\\Data\\NewTextFile.csv");

foreach (Student student in sortedList)
{
    writer.WriteLine(student.ToCSV());
}
*/

/*
StreamWriter writer = new StreamWriter(new FileStream(locationOfProject + "\\Data\\NewTextFile.csv", FileMode.Append, FileAccess.Write));
writer.WriteLine("Enumber,FirstName,LastName,ServiceTag");
writer.Close();
*/

var fm = new FileManipulate("/Data/InClass.csv", FileMode.Append, FileAccess.ReadWrite) ;

var location = fm.CreateACopyOfTheFile();

Console.WriteLine(location);

fm.Close();



/*
var text = reader.ReadLine();
var text1 = reader.ReadLine();
var text2 = reader.ReadLine();

Console.WriteLine(text);
Console.WriteLine(text1);
Console.WriteLine(text2);
*/



//when I finish....

//List<Student> students = new List<Student>();

//students.Add(new Student("E00716447", "Brooke", "Acevedo", "FS217M3"));