using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MLModel1_ConsoleApp1
{
    public class ConsoleOut
    {
        private static void Hello()
        { 
            DateTime now = DateTime.Now;
            DateTime night = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            DateTime morning = new DateTime(now.Year, now.Month, now.Day, 5, 0, 0);
            DateTime day = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);
            DateTime evening = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0);

            if (now >= night && now < morning)
            {
                Console.WriteLine("=============== Доброй ночи! ===============");
            }
            else if (now >= morning && now < day)
            {
                Console.WriteLine("Доброе утро!");
            }
            else if (now >= day && now < evening)
            {
                Console.WriteLine("Добрый день!");
            }
            else 
            { 
                Console.WriteLine("=============== Добрый вечер! ===============\n"); 
            }
        }

        public static void PrintPredictionResult(MLModel1.ModelInput sampleData, MLModel1.ModelOutput predictionResult)
        {
            Hello();
            
            Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");


            //Console.WriteLine($"Label: {0F}");
            Console.WriteLine($"Text: {sampleData.Text}");


            Console.WriteLine($"\n\nPredicted Label: {predictionResult.PredictedLabel}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
