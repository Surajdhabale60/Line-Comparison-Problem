using static LineComparison.LineMain;

namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LineMain lineMain = new LineMain(1,2,3,4);
            lineMain.Calculate();
        }
    }
}