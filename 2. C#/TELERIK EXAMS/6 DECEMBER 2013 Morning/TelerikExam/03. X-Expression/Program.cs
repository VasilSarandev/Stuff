using System;
    class Program
    {
        static void Main(string[] args)
        {
            string GivenExpression = Console.ReadLine();
            string newArray = "";
            for (int i = 0; i < GivenExpression.Length - 1; i++)
            {
                   newArray += GivenExpression[i];
            }
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            var res = obj.Eval(newArray);
            Console.WriteLine(res);
        }
    }

