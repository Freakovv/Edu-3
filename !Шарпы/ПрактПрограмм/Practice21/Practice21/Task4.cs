using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice21
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Task4
    {
        private static readonly string[] Months = {
        "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
        "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
    };

        public static Dictionary<string, double[]> GenerateTemperatures()
        {
            var random = new Random();
            var temperatures = new Dictionary<string, double[]>();

            foreach (var month in Months)
            {
                double[] monthTemperatures = new double[30];
                for (int day = 0; day < 30; day++)
                {
                    // от -30 до +35 градусов
                    monthTemperatures[day] = Math.Round(random.NextDouble() * 65 - 30, 1);
                }
                temperatures.Add(month, monthTemperatures);
            }

            return temperatures;
        }

        public static Dictionary<string, double> CalculateMonthlyAverages(Dictionary<string, double[]> temperatures)
        {
            var averages = new Dictionary<string, double>();

            foreach (var month in temperatures)
            {
                double sum = 0;
                foreach (var temp in month.Value)
                {
                    sum += temp;
                }
                averages.Add(month.Key, Math.Round(sum / month.Value.Length, 1));
            }

            return averages;
        }

        public static void PrintMonthlyTemperatures(Dictionary<string, double[]> temperatures)
        {
            foreach (var month in temperatures)
            {
                Console.WriteLine($"{month.Key}: {string.Join(" ", month.Value)}");
            }
        }

        public static void PrintMonthlyAverages(Dictionary<string, double> averages)
        {
            foreach (var avg in averages.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{avg.Key}: средняя температура = {avg.Value}°C");
            }
        }
    }
}
