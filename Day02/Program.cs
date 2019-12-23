using System;

namespace DedMraz02
{
    class Program
    {
        static string[] inputs;
        static int[] inputCodes;
        static bool flag;

        static void Main(string[] args)
        {
            inputs = System.IO.File.ReadAllText("input.txt").Split(',');
            inputCodes = new int[inputs.Length];
            SetParameters();
            TryParameters();        
        }

        private static void SetParameters()
        {
            ResetMemory();
            inputCodes[1] = 12;
            inputCodes[2] = 2;
            Run();
            Console.WriteLine(inputCodes[0]);
        }

        private static void TryParameters()
        {
            for(int i=0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    ResetMemory();
                    inputCodes[1] = i;
                    inputCodes[2] = j;
                    Run();
                    if (inputCodes[0] == 19690720)
                    {
                        Console.WriteLine(i*100+j);
                        return;
                    }
                }

            }
        }

        private static void Run()
        {
            flag = false;
            for (int i = 0; i < inputCodes.Length; i += 4)
            {
                switch (inputCodes[i])
                {
                    case 1:
                        inputCodes[inputCodes[i + 3]] = inputCodes[inputCodes[i + 1]] + inputCodes[inputCodes[i + 2]];
                        break;
                    case 2:
                        inputCodes[inputCodes[i + 3]] = inputCodes[inputCodes[i + 1]] * inputCodes[inputCodes[i + 2]];
                        break;
                    case 99:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("nEŠT PO Krivu Stari!");
                        flag = true;
                        break;
                }
                if (flag)
                {
                    break;
                }
            }
        }

        private static void ResetMemory()
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                inputCodes[i] = int.Parse(inputs[i]);
            }
        }
    }
}
