using System;
using System.Collections.Generic;

namespace Курсовая_работа
{
    /// <summary>
    /// Хранит данные об эксперименте.
    /// </summary>
    public class ExperimentData
    {
        /// <summary>
        /// Имя эксперимента.
        /// </summary>
        public string Name;

        /// <summary>
        /// Список InputData хранит входные данные эксперимента.
        /// </summary>
        public List<double> InData = new List<double>();

        /// <summary>
        /// Список InputData хранит выходные данные эксперимента.
        /// </summary>
        public List<double> OutData;

        public double MaxAbs, Sum, MaxAbsChart, Max, Min;

        void SumCalc()
        {
            int i = 0;
            foreach (var element in InData)
            {
                if (element > 0) break;
                i++;
            }

            Sum = 0;
            int j = 0;

            foreach (var element in InData)
            {
                if (j > i)
                    if (element <= 0) Sum += element;
                    else break;
                else j++;
            }
        }

        void MaxAbcCalc()
        {
            MaxAbsChart = Sum;

            foreach (var element in InData)
                if (MaxAbsChart < Math.Abs(element))
                {
                    MaxAbs = element;
                    MaxAbsChart = Math.Abs(element);
                }
        }

        void Maximum()
        {
            byte i = 0;
            foreach (var element in InData)
            {
                if (i == 0)
                {
                    Max = element;
                    i++;
                }
                if (Max < element) Max = element;
            }
        }

        void Minimum()
        {
            byte i = 0;
            foreach (var element in InData)
            {
                if (i == 0)
                {
                    Min = element;
                    i++;
                }
                if (Min > element) Min = element;
            }
        }

        /// <summary>
        /// Перемещает все нули в конец входного массива.
        /// </summary>
        List<double> Zero()
        {
            List<double> OutDataNew = new List<double>();

            foreach (var element in InData)
                OutDataNew.Add(element);

            var Count = OutDataNew.Count - 1; // InData.Count - 1 // для отчета с нуля.

            for (int i = 0; i < Count; i++)
            {
                if (GetData(OutDataNew, i) == 0)
                {
                    double temp1 = GetData(OutDataNew, Count), temp2 = 0;

                    for (int j = Count; j != i; j--)
                    {
                        temp2 = temp1;
                        temp1 = GetData(OutDataNew, j - 1);
                        SetData(OutDataNew, temp2, j - 1);
                    }

                    SetData(OutDataNew, 0, Count);
                    Count--;
                }
            }

            return OutDataNew;
        }

        /// <summary>
        /// Инициализирует и заполняет список OutData.
        /// Для этого нужен заполненный список InData.
        /// </summary>
        public void OutDataCalc()
        {
            SumCalc();
            MaxAbcCalc();

            OutData = new List<double>();

            OutData.Add(MaxAbs);
            OutData.Add(Sum);

            foreach (var element in Zero())
                OutData.Add(element);

            Maximum();
            Minimum();
        }

        /// <summary>
        /// Возвращает элемент из списка Data с указанным индексом.
        /// </summary>
        public double GetData(List<double> Data, int Index)
        {
            if(Index > Data.Count) return 0;
            
            int i = 0;
            foreach (var element in Data)
            {
                if (i == Index) return element;
                i++;
            }

            return 0;
        }

        /// <summary>
        /// Вставляет элемент в список в позицию с указанным индексом.
        /// </summary>
        public void SetData(List<double> Data, double data, int Index)
        {
            if (Index > Data.Count) return;

            try { Data.RemoveAt(Index); } catch { }

            Data.Insert(Index, data);
        }
    }
}
