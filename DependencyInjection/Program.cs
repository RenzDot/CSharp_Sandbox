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
            var duck = new Context();
            duck.SetStrategy(new ConcreteStrategyA());//SetStrategy() could be FlyingStrategy()

            //Generic Example
            var someContext = new Context();

            //Set Strategy set to normal sorting
            someContext.SetStrategy(new ConcreteStrategyA());
            someContext.SomeBusinessLogic();

            //Set Strategy set to reverse sorting
            someContext.SetStrategy(new ConcreteSrategyB());
            someContext.SomeBusinessLogic();
        }
    }

    public interface IStrategy 
    {//With IStrategy, we can split to StrategyA & StrategyB
        object DoAlgorithm(object data);//Frequently changing code
    }

   public class ConcreteStrategyA: IStrategy
   {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }

    public class ConcreteSrategyB: IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }

    public class Context 
    {
        private IStrategy _strategy;
        public Context() { }

        public Context(IStrategy strategy) {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy) {
            this._strategy = strategy;
        }

        public void SomeBusinessLogic() {
            Console.WriteLine("Context: Sorting (don't care how it's done)");
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c" });
            Console.WriteLine(string.Join(", ", result));
        }
    }
}