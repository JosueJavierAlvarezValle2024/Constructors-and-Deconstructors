using Constructors_and_Deconstructors;

// Creation of objects
Person _person = new Person("Gustavo",22,1.84);
Estudent _student = new Estudent("Maria",20,1.59,"Female", "Nursing");

// Methods
_person.Presentation();
Console.WriteLine();
_student.StudentPresentation();
Console.WriteLine();
_student.Presentation();

// Delete objects explicitly
_person = null;
_student=null;

 Console.ReadLine();