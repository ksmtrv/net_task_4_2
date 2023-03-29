namespace net_task_4_2
{
    internal class MobileOperatorDerived : MobileOperator
    {
        protected bool feeForEachConnection { get; set; } //плата за подключение

        public MobileOperatorDerived(string name, double callCost, int coverageArea, bool feeForEachConnection) : base(name, callCost, coverageArea)
        {
            this.feeForEachConnection = feeForEachConnection;
        }

        override protected double GetQuality() //качество связи
        {
            return feeForEachConnection ? 0.7 * base.GetQuality() : 1.5 * base.GetQuality();
        }

        public override string GetInfoStr() //получить информацию
        {
            return base.GetInfoStr() + $", fee for each conn is {feeForEachConnection}";
        }
    }
}