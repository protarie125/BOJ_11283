using System;
using System.Text;

namespace BOJ_11283
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {
            var zero = "가";
            var zs = Encoding.UTF8.GetBytes(zero);
            var zv = 64 * 64 * (zs[0] - 234) + 64 * (zs[1] - 128) + (zs[2] - 128);

            var read = Console.ReadLine();
            var ws = Encoding.UTF8.GetBytes(read);
            var wv = 64 * 64 * (ws[0] - 234) + 64 * (ws[1] - 128) + (ws[2] - 128) - zv + 1;

            Console.WriteLine(wv);
        }
    }
}