using System;

namespace CSE.Utilities
{
    public class AwesomeUtilities
    {
        public bool IsStringLong(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException("Data is null or empty.");

            int len = data.Length;

            return len > 5;
        }
    }
}
