using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mawa.Randoms
{
    public class RandomId
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string Model_Id()
        {
            return RandomString(16).ToLower();
        }

        public static string Object_Id()
        {
            return RandomString(20).ToLower();
        }

        public static string EditObject_Id()
        {
            return RandomString(32).ToLower();
        }

        public static string FileMeName()
        {
            return RandomString(20).ToLower();
        }

        public static string ProcessLockerId()
        {
            return RandomString(21).ToLower();
        }

    }
}
