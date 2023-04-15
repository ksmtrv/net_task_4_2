namespace net_task_4_2
{
    internal class MobileOperatorDerived : MobileOperator
    {
        protected bool feeForEachConnection { get; set; } //плата за подключение

        public MobileOperatorDerived(string name, double callCost, int coverageArea, bool feeForEachConnection) : base(name, callCost, coverageArea)
        {
            this.feeForEachConnection = feeForEachConnection;
        }

        public override double GetQuality() //качество связи
        {
            return base.GetQuality()  * (feeForEachConnection ? 0.7 : 1.5);
        }

        public override string GetInfoStr() //получить информацию
        {
            return base.GetInfoStr() + $",\n connection fee {feeForEachConnection}";
        }
    }
}