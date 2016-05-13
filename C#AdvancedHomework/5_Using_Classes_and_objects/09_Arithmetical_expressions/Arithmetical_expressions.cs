/*Description
Write a program that calculates the value of given arithmetical expression.
The expression can contain the following elements only:
•	Real numbers, e.g. 5, 18.33, 3.14159, 12.6
•	Arithmetic operators: +, -, *, / (standard priorities)
•	Mathematical functions: ln(x), sqrt(x), pow(x,y)
•	Brackets (for changing the default priorities): (, )
Input
•	On the only line you will receive an expression
Output
•	Print the result of the expression
 * 
 * This code is directly taken from:
 * https://social.msdn.microsoft.com/Forums/vstudio/en-US/4f21a85b-ba17-492b-9344-4654473e3adc/how-to-calculate-the-value-of-input-string-in-c-40-easily?forum=csharpgeneral
 * but does not work for mathematical functions as sqrt, ln, pow. 
*/

using System;
using System.Reflection;
using System.CodeDom.Compiler;
using System.Data;
//using org.mariuszgromada.math.mxparser;


class Arithmetical_expressions
{
    static void Main()
    {
        //we need math parser?

        //Console.WriteLine("Enter an expression to calculate: ");
        //string expression = Console.ReadLine();
        //TestExpression(expression);

        //second way: use the class DataTable, but again math functions are missing
        DataTable dt = new DataTable();
        string expression = Console.ReadLine();
        var v = dt.Compute(expression, "");
        Console.WriteLine(v);

        //Third way: 
        //I am using VS2013, but in VS2015 is possible to import the Reference mxParser.dll
        //Thenonly what we need is to write something like: 
        //Expression eh = new Expression("expression");
        //Expression ew = new Expression("expression");
        //String h = mXparser.numberToAsciiString(eh.calculate());
        //String w = mXparser.numberToAsciiString(ew.calculate());
        //mXparser.consolePrintln(h + " " + w);

    }

    static void TestExpression(string expression)
    {
        try
        {
            double result = EvaluateExpression(expression);
            Console.WriteLine("'" + expression + "' = " + result);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Expression is invalid: '" + expression + "' because " + ex.Message);
        }
    }

    public static double EvaluateExpression(string expression)
    {
        string code = string.Format // Note: Use "{{" to denote a single "{"
        (
          "using System;\n" +
        "public static class Func{{ public static double func(){{ return {0};}}}}",
          expression
        );

        CompilerResults compilerResults = CompileScript(code);

        if (compilerResults.Errors.HasErrors)
        {
            throw new InvalidOperationException("Expression has a syntax error.");
        }

        Assembly assembly = compilerResults.CompiledAssembly;
        MethodInfo method = assembly.GetType("Func").GetMethod("func");

        return (double)method.Invoke(null, null);
    }

    public static CompilerResults CompileScript(string source)
    {
        CompilerParameters parms = new CompilerParameters
        {
            GenerateExecutable = false,
            GenerateInMemory = true,
            IncludeDebugInformation = false
        };

        CodeDomProvider compiler = CodeDomProvider.CreateProvider("CSharp");

        return compiler.CompileAssemblyFromSource(parms, source);
    }

}



