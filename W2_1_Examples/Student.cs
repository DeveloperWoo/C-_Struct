namespace W2_1_Struct_Class
{
    enum StudentStatus
    {
        FullTime,
        PartTime
    }

    struct Student
    {
        public int Id;
        public string Name;
        public double Gpa;

        public StudentStatus Status;

        //Constructor
        public Student(int id, string name, double gpa) //No default ctor. We have to fill it by assigning its variables
        {
            Id = id;
            Name = name;
            Gpa = gpa;
            Status = StudentStatus.FullTime;
        }

        public string Information()
        {
            return $" {Id} - {Name} - {Gpa}"; // We'd better use toString() method in Java / ToString() method in C#
        }

        public override string ToString()
        {
            return $" {Id} - {Name} - {Gpa}";
        }
    }
}
