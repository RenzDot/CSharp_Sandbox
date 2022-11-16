/* Strategy Pattern (uses Dependency Injection)
Change behavior of a class without extending it

Take a class doing something specific in many ways
Extract all of these ways/algorithms into separate classes

Each class is called  a "Strategy"
User passes desired strategy to the context

Source: https://refactoring.guru/design-patterns/strategy/csharp/example#lang-features
*/
namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args) {
            //Duck Example
            var duck = new Bird();
            duck.FlyingStrategy(new FlyBackwardsStrategy());//SetStrategy() could be FlyingStrategy()

            //Generic Example
            var someContext = new Bird();

            //Set Strategy set to normal sorting
            duck.FlyingStrategy(new FlyBackwardsStrategy());
            duck.Fly();

            //Set Strategy set to reverse sorting
            duck.FlyingStrategy(new FlyForwardStrategy());
            duck.Fly();
        }
    }

    public interface IStrategy 
    {//With IStrategy, we can split to StrategyA & StrategyB
        object DoAlgorithm(object data);//Frequently changing code
    }

   public class FlyBackwardsStrategy: IStrategy
   {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }

    public class FlyForwardStrategy: IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }

    public class Bird 
    {
        private IStrategy _strategy;
        public Bird() { }

        public Bird(IStrategy strategy) {
            _strategy = strategy;
        }

        public void FlyingStrategy(IStrategy strategy) {
            this._strategy = strategy;
        }

        public void Fly() {
            Console.WriteLine("Context: Sorting (don't care how it's done)");
            var result = this._strategy.DoAlgorithm(new List<string> { "pond", "house", "beach" });
            Console.WriteLine(string.Join(", ", result));
        }
    }
}