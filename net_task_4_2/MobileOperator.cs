using System;

namespace net_task_4_2
{
    internal class MobileOperator
    {
        protected String name { get; set; }
        protected double callCost { get; set; } //цена
        protected int coverageArea { get; set; } //зона покрытия

        public MobileOperator(string name, double callCost, int coverageArea)
        {
            this.name = name;
            if (callCost < 0)
            {
                throw new ArgumentException("call cost must be greater than 0!");
            }
            this.callCost = callCost;

            if (coverageArea < 0)
            {
                throw new ArgumentException("coverage area must be greater than 0!");
            }
            this.coverageArea = coverageArea;
        }

        protected virtual double GetQuality() //качество связи
        {
            return 100 * coverageArea / callCost;
        } 

        public virtual String GetInfoStr() //получить информацию 
        {
            return $"Mobile operator: {name}, call cost: {callCost}, coverage area: {coverageArea}, Q = {GetQuality()}";
        }
    }
}