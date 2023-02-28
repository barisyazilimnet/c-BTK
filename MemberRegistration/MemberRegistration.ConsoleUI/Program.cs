using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member{Email = "kurt-bar07@hotmail.com", FirstName = "Barış", LastName = "KURT", DateOfBirth = new DateTime(2000,01,30), TcNo = "21487287098"});
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
