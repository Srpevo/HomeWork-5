using University;

Student Student_1 = new Student();
Student Student_2 = new Student();

try
{
    //normal data filling without getting exceptions
    Student_1.Student_Name = "Hakob";
	Student_1.Student_Age = 16;
	Student_1.Student_Group = Student.Groupes.first;
	Student_1.Student_University = "RAU University";
	//incorrect data entry which will ultimately lead to an exception being thrown
	//Student_2.Student_Name = "";
	//Student_2.Student_Age = -10;
	//Student_2.Student_Group = Student.Groupes.second;
	//Student_2.Student_University = "RUK";

    Student_1.ShowInfo(); //getting information about a student

}
catch (Exception ex)
{
	Console.WriteLine("incorrect data filling reason: {0}", ex.Message);
}

