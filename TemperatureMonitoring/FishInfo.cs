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
        int max;
        int maxTime;
        int min;
        int minTime;
        DateTime date;
        int[] temperature;
        List<string> excessMaximum = new List<string>();
        List<string> excessMinimum = new List<string>();

        public FishInfo(string fishType, int max, int maxTime, int min, int minTime, DateTime date, int[] temperature)
        {
            this.fishType = fishType;
            this.max = max;
            this.maxTime = maxTime;
            this.min = min;
            this.minTime = minTime;
            this.date = date;
            this.temperature = temperature;
        }
        public FishInfo(string fishType, string max, string maxTime, string min, string minTime, string date, string temperature)
        {
            string[] values;
            this.fishType = fishType;
            values = max.Trim().Split(" ");
            this.max = (int.Parse(max));
            this.maxTime = (int.Parse(maxTime));
            values = min.Trim().Split(" ");
            this.min = (int.Parse(min));
            this.minTime = (int.Parse(minTime));

            this.temperature = TemperatureConverter(temperature);
            this.date = DateConverter(date.Trim().Split('.', ' ', ':'));
        }

        static FishInfo Converter(string fishType, string max, string min, string date, string temperature)
        {
            string[] values;
            values = max.Trim().Split(" ");
            int maxData = (int.Parse(values[0]));
            int maxTimeData = (int.Parse(values[1]));
            values = min.Trim().Split(" ");
            int minData = (int.Parse(values[0]));
            int minTimeData = (int.Parse(values[1]));

            int[] temperatureData = TemperatureConverter(temperature);
            DateTime dater = DateConverter(date.Trim().Split('.', ' ', ':'));
            FishInfo fish = new FishInfo(fishType, maxData, maxTimeData, minData, minTimeData, dater, temperatureData);
            return fish;
        }

        static int[] TemperatureConverter(string temperature)
        {
            string[] splitedTemperature = temperature.Trim().Split(" ");
            int[] temperatureData = new int[splitedTemperature.Length];

            for (int i = 0; i < splitedTemperature.Length; i++)
            {
                temperatureData[i] = Convert.ToInt32(splitedTemperature[i]);
            }
            return temperatureData;
        }

        public string Check()
        {
            string text = "";
            int maxWrongTemp = 0;
            int minWrongTemp = 0;
            DateTime tempDate = date;
            foreach (int i in temperature)
            {
                if (i > max)
                {
                    maxWrongTemp += 10;
                    excessMaximum.Add($"{tempDate} \t {i} \t {max} \t {i - max}\n");
                }
                if (i < min)
                {
                    minWrongTemp += 10;
                    excessMinimum.Add($"{tempDate} \t {i} \t {min} \t {i - min}\n");
                }
                tempDate = tempDate.AddMinutes(10);
            }
            if (maxWrongTemp > maxTime)
            {
                text += $"Порог максимально допустимой температуры превышен на {maxWrongTemp} минут \n";
                foreach (string i in excessMaximum)
                {
                    text += i;
                }
            }
            if (minWrongTemp > minTime)
            {
                text += $"Порог минимально допустимой температуры превышен на {minWrongTemp} минут\n";
                foreach (string i in excessMinimum)
                {
                    text += i;
                }
            }
            if (maxWrongTemp < maxTime && minWrongTemp < minTime)
            {
                text += "Все хорошо";
            }
            return text;
        }


        //static void Load(string path)
        //{
        //    foreach (var file in Directory.GetFiles(path, "*.txt*"))
        //    {
        //        Console.WriteLine(file);
        //        DATA.Add(file);
        //        using (StreamReader reader = new StreamReader(file, false))
        //        {
        //            string str = reader.ReadLine();
        //            while (str != null)
        //            {
        //                try
        //                {
        //                    Converter(str);
        //                }
        //                catch
        //                {
        //                    str = reader.ReadLine();
        //                }
        //                str = reader.ReadLine();
        //            }
        //        }
        //    }
        //}

        //static void Save(string path)
        //{
        //    using (StreamWriter writer = new StreamWriter(path, false))
        //    {
        //        foreach (var item in DATA)
        //        {
        //            writer.WriteLine(item);
        //        }
        //    }
        //}

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

        public override string ToString()
        {
            string fishInfo = ($"{fishType}, {max}, {maxTime}, {min}, {minTime}, {date}; ");
            for(int i = 0; i < temperature.Length; i++)
            {
                fishInfo += i + ", ";
            }
            //foreach(int i in this.temperature)
            //{
            //    fishInfo += i + ", ";
            //}
            return fishInfo;
        }
    }
}
