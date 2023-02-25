using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            Teacher teacher = new Teacher(mediator);
            teacher.Name = "Barış";
            mediator.Teacher = teacher;

            Student student = new Student(mediator);
            student.Name = "Güldane";

            Student student2 = new Student(mediator);
            student2.Name = "Beyza";

            mediator.Students = new List<Student> { student, student2 };

            teacher.SendNewImageUrl("slide.png");
            teacher.RecieveQuestion("Is it true?", student);
            Console.ReadLine();
        }
    }
    abstract class CourseMember
    {
        protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
    class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {
        }
        public string Name { get; set; }
        internal void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine(Name + " recieved a question from {0}, {1}", student.Name, question);
        }
        public void SendNewImageUrl(string url)
        {
            Console.WriteLine(Name + " changed slide : " + url);
            Mediator.UpdateImage(url);
        }
        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine(Name + " answered question {0}, {1}", student.Name, answer);
        }
    }
    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public string Name { get; set; }

        internal void RecieveImage(string url)
        {
            Console.WriteLine(Name + " recieve image : " + url);
        }

        internal void RecieveAnswer(string answer, Student student)
        {
            Console.WriteLine(Name + " recieved answer : " + answer);
        }
    }
    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public void UpdateImage(string url)
        {
            foreach (var student in Students)
            {
                student.RecieveImage(url);
            }
        }
        public void SendQuestion(string question, Student student)
        {
            Teacher.RecieveQuestion(question, student);
        }
        public void SendAnswer(string answer, Student student)
        {
            student.RecieveAnswer(answer, student);
        }
    }
}
