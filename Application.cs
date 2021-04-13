using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    /// <summary>
    /// Facade pattern  (Freeman et al., 2004, pp.243–278)
    /// 
    /// Definition (Freeman et al., 2004, pp.243–278)
    /// "Provides a unified interface to a set of interfaces in a 
    /// subsystem. Facade defines a higher - level interface that 
    /// makes the subsystem easier to use"
    /// 
    /// Proms
    /// - Isolate the code from a main sub-system.
    /// - Add an easy way to control a lot of classes at one place.
    /// 
    /// Cons
    /// - Depending on the use can violate Single responsibility 
    /// principle. By containing a class that runs small algorithms.
    /// 
    /// 
    /// 
    /// Singleton Pattern (Freeman et al., 2004, pp.171–188)
    /// 
    /// Definition (Freeman et al., 2004, pp.171–188)
    /// "Ensures a class only has one instance and provides a global point of access to it."
    /// 
    /// Proms
    /// - Ensure that class has only one instance
    /// - Class has a global access point. Can be access from any class.
    /// - Class is only initialized ones, in the first request. After uses the same instance.
    /// 
    /// Cons
    /// - Violates single responsibility principle. Solves two problems at ones.
    /// - Pattern can mask bad design. Making it hard to identify and 
    /// solve. E.g.: then component know too much about each other.
    /// - Then used in multithreading can create multiple singleton objects. 
    /// - Hard to unit test as almost all parameters and method are private and override static.
    /// 
    /// 
    /// 
    /// Strategy Pattern (Shvets, 2021, pp.369–381)
    /// 
    /// Definition (Freeman et al., 2004, pp.1–32)
    /// “Defines a family of algorithms encapsulates each one, and 
    /// makes them interchangeable. Strategy lets the algorithm vary 
    /// independently from client that use it.”
    /// 
    /// Proms
    /// - Make it easy to swope between deferent algorithms.
    /// - Isolates algorithms from a main code.
    /// - Replaces inheritance with composition.
    /// - Open-closed principle. Can add a new feature without any main changes. 
    /// 
    /// Cons
    /// - Then shouting a deferent algorithm, client 
    /// should know that each of them do and/or produce.
    /// - If program has just a few algorithms it is not worth 
    /// it to use this patter as it uses more processing power and storage.
    /// 
    /// 
    /// 
    /// 
    /// References
    /// 
    /// Freeman, E., Robson, E., Bates, B. and Sierra, K., 2004. Head First Design Patterns. 1st edition ed. 
    /// Sebastopol, CA: O’Reilly Media.
    /// 
    /// Shvets, A., 2021. Modern Book on Design Patterns: Dive Into Design Patterns. [online] Available at: 
    /// <https://refactoring.guru/design-patterns/book> [Accessed 19 Feb. 2021].
    /// 
    /// </summary>
    // Facade pattern - client
    class Application 
    {
        public void Run()
        {
            //Singleton Pattern - Instantiates Game class
            Game.GetInstance(); 
            Console.ReadKey(true);
        }
    }
}
