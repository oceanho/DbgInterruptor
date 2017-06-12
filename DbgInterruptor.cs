using System;
using using System.Threading.Tasks;
namespace System
{
    public sealed class DbgInterruptor
    {
        private static bool _isPassed = false;
        public static void Wait()
        {
            while (!(_isPassed))
            {
                Task.WaitAll(Task.Delay(1000));
            }
        }

        public static void Break()
        {
            _isPassed = true;
        }
    }
}
