using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescrption() + Environment.NewLine + "Cost:" + beverage.Cost());

            //var mocha = new Mocha(beverage);
            //var mocha2 = new Mocha(mocha);
            //var soy = new Soy(mocha2);
            //var whip = new Whip(soy);

            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Soy(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.getDescrption() + Environment.NewLine + "Cost:" + beverage.Cost());


            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }

    //抽象基类 饮料基类
    //抽象基类 饮料基类
    public abstract class Beverage
    {
        public abstract string getDescrption();

        public abstract double Cost();
    }

    //装饰者 抽象类 调料类
    public class CondimentDecorator : Beverage
    {
        Beverage beverage;
        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return beverage.Cost();
        }

        public override string getDescrption()
        {
            return beverage.getDescrption();
        }
    }

    //具体咖啡种类--浓缩咖啡
    public class Espresso : Beverage
    {
        public override double Cost()
        {
            return 1.99;
        }

        public override string getDescrption()
        {
            return "Espresso";
        }
    }

    //具体咖啡种类--HouseBlend
    public class HouseBlend : Beverage
    {
        public override double Cost()
        {
            return 0.89;
        }

        public override string getDescrption()
        {
            return "House Blend Coffee";
        }
    }

    //调料类--摩卡
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
            : base(beverage)
        {

        }

        public override double Cost()
        {
            return base.Cost() + 0.20;
        }

        public override string getDescrption()
        {
            return base.getDescrption() + ",Mocha";
        }
    }

    //调料类--Soy
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
            : base(beverage)
        {

        }
        public override double Cost()
        {
            return base.Cost() + 0.3;
        }

        public override string getDescrption()
        {
            return base.getDescrption() + ",Soy";
        }
    }
    //调料类--Whip
    public class Whip : CondimentDecorator
    {

        public Whip(Beverage beverage)
            : base(beverage)
        {

        }
        public override double Cost()
        {
            return base.Cost() + 0.4;
        }

        public override string getDescrption()
        {
            return base.getDescrption() + ",Whip";
        }
    }
}
