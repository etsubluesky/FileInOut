namespace FileInOut
{
    public class Student
    {
        public string Enumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DellServiceNumber { get; set; }


        public Student(string Enumber, string firstName, string lastName, string dellServiceNumber)
        {
           this.Enumber = Enumber;
           this.FirstName = firstName;
           this.LastName = lastName;
           this.DellServiceNumber = dellServiceNumber;

        }

        public string FullName()
        {
            return FirstName + " " + LastName; 
        }

        public string FirstNamePlusLastNameI()
        {
            return FirstName + " " + LastName[0] + ".";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} with an ENumber of {Enumber} has Dell Computer: {DellServiceNumber}";
        }

        public string ToCSV()
        {
            return $"{Enumber},{FirstName},{LastName},{DellServiceNumber}";
        }
    }
}
