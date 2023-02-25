using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personelcar = new PersonelCar { Make = "BMW", Model = "3.20", HirePrice = 2500 };
            SpecialOffer specialOffer = new SpecialOffer(personelcar);
            specialOffer.DiscountPercentage = 10;
            Console.WriteLine("Concrete : " + personelcar.HirePrice);
            Console.WriteLine("Special Offer : " + specialOffer.HirePrice);
            Console.ReadLine();

        }
    }
    abstract class CarBase
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }
    class PersonelCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }
    class CommercialCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    abstract class CarDecoratorBase : CarBase
    {
        private CarBase _carbase;
        protected CarDecoratorBase(CarBase carbase)
        {
            _carbase = carbase;
        }
    }
    class SpecialOffer : CarDecoratorBase
    {
        public int DiscountPercentage { get; set; }
        private readonly CarBase _carbase;

        public SpecialOffer(CarBase carbase) : base(carbase)
        {
            _carbase = carbase;
        }

        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get { return _carbase.HirePrice-_carbase.HirePrice * DiscountPercentage/100; } set { } }
    }
}
