using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CSharpVersions
{
    public static class Utility
    {
        public static void NamedArgumentsTask()
        {

            // The method can be called in the normal way, by using positional arguments.
            NamedArgument.PrintOrderDetails("Gift Shop", 31, "Red Mug");

            // Named arguments can be supplied for the parameters in any order.
            NamedArgument.PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
            NamedArgument.PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);

            // Named arguments mixed with positional arguments are valid
            // as long as they are used in their correct position.
            NamedArgument.PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
            NamedArgument.PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug");    // C# 7.2 onwards
            NamedArgument.PrintOrderDetails("Gift Shop", orderNum: 31, "Red Mug");                   // C# 7.2 onwards

            // However, mixed arguments are invalid if used out-of-order.
            // The following statements will cause a compiler error.
            // PrintOrderDetails(productName: "Red Mug", 31, "Gift Shop");
            // PrintOrderDetails(31, sellerName: "Gift Shop", "Red Mug");
            // PrintOrderDetails(31, "Red Mug", sellerName: "Gift Shop");
        }

        public static void OptionalArgumentsTask()
        {
            // Instance anExample does not send an argument for the constructor's
            // optional parameter.

            OptionalArguments.ExampleMethod(1, "One", 1);
            OptionalArguments.ExampleMethod(2, "Two");
            OptionalArguments.ExampleMethod(3);

            // Instance anotherExample sends an argument for the constructor's
            // optional parameter.

            OptionalArguments.ExampleMethod(required: 1, "One", 1);
            OptionalArguments.ExampleMethod(required: 2, "Two");
            OptionalArguments.ExampleMethod(3);

            // The following statements produce compiler errors.

            // An argument must be supplied for the first parameter, and it
            // must be an integer.
            //anExample.ExampleMethod("One", 1);
            //anExample.ExampleMethod();

            // You cannot leave a gap in the provided arguments.
            //anExample.ExampleMethod(3, ,4);
            //anExample.ExampleMethod(3, 4);

            // You can use a named parameter to make the previous
            // statement work.
            OptionalArguments.ExampleMethod(3, optionalint: 4);
        }

      public  static void dynamicExample()
        {
            DynamicRepository ec = new DynamicRepository();
            // The following call to exampleMethod1 causes a compiler error
            // if exampleMethod1 has only one parameter. Uncomment the line
            // to see the error.
            //ec.exampleMethod1(10, 4);

            dynamic dynamic_ec = new DynamicRepository();
            // The following line is not identified as an error by the
            // compiler, but it causes a run-time exception.
            dynamic_ec.exampleMethod1(10, 4);

            // The following calls also do not cause compiler errors, whether
            // appropriate methods exist or not.
            dynamic_ec.someMethod("some argument", 7, null);
            dynamic_ec.nonexistentMethod();
        }

    }

}

