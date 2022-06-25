using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace TemperatureMonitoring
{
    class FishInfo
    {
        string fishType;
        string max;
        string min;
        DateTime date;
        int[] temperature;
        static List<string> DATA = new List<string>();

        public FishInfo(string fishType, string max, string min, DateTime date, int[] temperature)
        {
            this.fishType = fishType;
            this.max = max;
            this.min = min;
            this.date = date;
            this.temperature = temperature;
        }

        public void Converter()
        {

            DateTime date = DateConverter(date.Trim().Split('.', ' ', ':'));
        }



        static void Load(string path)
        {
            foreach (var file in Directory.GetFiles(path, "*.txt*"))
            {
                Console.WriteLine(file);
                DATA.Add(file);
                using (StreamReader reader = new StreamReader(file, false))
                {
                    string str = reader.ReadLine();
                    while (str != null)
                    {
                        try
                        {
                            Converter(str);
                        }
                        catch
                        {
                            str = reader.ReadLine();
                        }
                        str = reader.ReadLine();
                    }
                }
            }
        }

        static void Save(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (var item in DATA)
                {
                    writer.WriteLine(item);
                }
            }
        }

        static DateTime DateConverter(string[] str)
        {
            int[] nums = new int[6];
            for (int i = 0; i < str.Length; i++)
            {
                nums[i] = int.Parse(str[i]);
            }
            DateTime date1 = new DateTime(nums[2], nums[1],
                                          nums[0], nums[3],
                                          nums[4], nums[5]);
            return date1;
        }
    }
}
