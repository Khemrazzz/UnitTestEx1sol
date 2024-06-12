using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestEx1.unitTesting
{
    public  static class demoFuncTest
    {
        //Make sure to name variables properly
        public static void demoFunct_demoFunctTest_ReturnsString()
        {
           // List<string> list = new List<string>();
           // list.ToArray();

            try
            {
                //Arrange - to go get variables needed such as classes, functions etccccc
                int[] num = { 3, 2, 1, 0 };
                demoFunct testDemo = new demoFunct();

                //Act - Execute the function
                
                for (int i = 0; i < num.Length; i++)
                {
                    String result = testDemo.ReturnsPIKifzero(i);
                    //Assert- the returned as predicted
                    if (result == "PIK")
                    {
                        Console.WriteLine("Test passed!");
                    }
                    else
                    {
                        Console.WriteLine("Test failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
