using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEducationService educationService = new EducationManager(new EfEducationDal(), new StdPriceUpdatedPrice());
            foreach (var education in educationService.ListEducations())
            {
                Console.WriteLine(education.Name + " = " + education.Price);
            }
            Console.ReadLine();
        }
    }
    public class Education : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public interface IEntity
    {
    }

    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;
        IOfferService _offerService;
        public EducationManager(IEducationDal educationDal, IOfferService offerService)
        {
            _educationDal = educationDal;
            _offerService = offerService;
        }
        public List<Education> ListEducations()
        {
            List<Education> educations = _educationDal.ListEducations();
            _offerService.UpdatePrice(educations);
            return educations;
        }
    }

    public interface IEducationService
    {
        List<Education> ListEducations();
    }
    public interface IEducationDal
    {
        List<Education> ListEducations();
    }
    public class EfEducationDal : IEducationDal
    {
        public List<Education> ListEducations()
        {
            return new List<Education>
            {
                new Education{ Id=1, Name="C# Kursu", Price=400},
                new Education{ Id=2, Name="Java Kursu", Price=300},
                new Education{ Id=3, Name="Python Kursu", Price=200},
            };
        }
    }
    public interface IOfferService
    {
        void UpdatePrice(List<Education> educations);
    }
    public class StdPriceUpdatedPrice : IOfferService
    {
        public void UpdatePrice(List<Education> educations)
        {
            foreach (var education in educations)
            {
                education.Price = CurrentPrice();
            }
        }
        private decimal CurrentPrice()
        {
            return 25;
        }
    }
    public class PercentDiscountUpdatedPrice : IOfferService
    {
        public void UpdatePrice(List<Education> educations)
        {
            foreach (var education in educations)
            {
                education.Price = education.Price - (education.Price * PercentDiscountGet());
            }
        }
        private decimal PercentDiscountGet()
        {
            return Convert.ToDecimal(0.90);
        }
    }
}
