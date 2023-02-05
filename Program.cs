namespace StingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ceaser codding
            //string text = StringTask.AddString();
            //Console.Write("Key: ");
            //int k = int.Parse(Console.ReadLine());

            //Console.WriteLine("Codding version: " + StringTask.Ceaser(k, text));
            #endregion

            #region Ceaser decodding
            //string text1 = StringTask.AddString();
            //Console.Write("Key: ");
            //int k1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Decodding version: " + StringTask.AntiCeaser(k1, text1));

            #endregion

            #region Time Difference
            string text1 = StringTask.AddTime();
            string text2 = StringTask.EndTime();

            Console.WriteLine("Date: " + StringTask.DifferenceTime(text1, text2));
            #endregion
        }
    }
}