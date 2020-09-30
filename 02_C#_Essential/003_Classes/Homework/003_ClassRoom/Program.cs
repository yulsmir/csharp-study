using System;
using _003_ClassRoom.Classes;
using _003_ClassRoom.Classes.Pupils;

//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Требуется:  Создать класс, представляющий учебный класс ClassRoom.  
//Создайте класс ученик Pupil.  
//В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil  от класса базового класса Pupil 
//и переопределите каждый из методов, в зависимости от успеваемости ученика.   
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.  
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.  

namespace _003_ClassRoom
{
    class Program
    {
        static void Main()
        {
            
            Pupil pupil1 = new Pupil("Oscar Ivanov", 5, 5);
            Pupil pupil2 = new Pupil("John Petroff", 4, 5);
            Pupil pupil3 = new Pupil("Mary Pupkina", 3, 4);
            ExcellentPupil pupil4 = new ExcellentPupil("Ivanka Tutsi", 2, 5);

            ClassRoom classRoom = new ClassRoom("1-A", pupil1, pupil2, pupil3, pupil4);
            Console.ReadKey();
        }
    }
}
