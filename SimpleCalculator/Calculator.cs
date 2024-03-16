namespace SimpleCalculator
{
    public class Calculator
    {
        private List<char> charlList = new();

        private List<double> collectorList = new();


        public string Multiple() => (collectorList[0] * collectorList[1]).ToString();
        public string Addition() => (collectorList.Sum()).ToString();
        public string Division() => (collectorList[0] / collectorList[1]).ToString();
        public string Subtract() => (collectorList[0] - collectorList[1]).ToString();


        public void AddCharToList(char c)
        {
            charlList.Add(c);
        }

        public string PrintAllCharToDisplay()
        {
            string total = string.Empty;
            charlList.ForEach(c => total = total + c.ToString());
            return total;
        }

        public void AddNumberToListCollector(string number)
        {
            collectorList.Add(double.Parse(number));
        }

        public void ClearCharList()
        {
            charlList.Clear();
        }

        public void ClearCollectorList()
        {
            collectorList.Clear();
        }
    }
}
