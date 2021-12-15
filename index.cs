    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static Tuple<string, int, float,bool,string[]> Main()
            {
                // TODO
                var name = "John";
                var age = 25;
                var weight = 78.4f;
                var isHuman = true;
                var friends = new string[]{"Paul","Sam","David"};
                
                return new Tuple<string, int, float,bool,string[]>
                    (name, age, weight, isHuman, friends);
            }
        }
    }