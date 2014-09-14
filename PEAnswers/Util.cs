using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class Util
    {
        public static Func<T, R> Memoize<T, R>(Func<T, R> f)
        {
            Dictionary<T, R> cache = new Dictionary<T, R>();

            return new Func<T, R>(key =>
            {
                R result;
                if (cache.TryGetValue(key, out result))
                    return result;

                result = f(key);

                cache.Add(key, result);
                return result;
            });
        }

        public static Func<T, K, R> Memoize<T, K, R>(Func<T, K, R> f)
        {
            Dictionary<Tuple<T, K>, R> cache = new Dictionary<Tuple<T, K>, R>();

            return new Func<T, K, R>((t, k) =>
            {
                var key = Tuple.Create(t, k);
                R result;
                if (cache.TryGetValue(key, out result))
                    return result;

                result = f(t, k);
                cache.Add(key, result);

                return result;
            });
        }
    }
}
