using ProjectEuler.Shared;

namespace ProjectEuler.Problem32_PandigitalProducts
{
    public static class PandigitalProducts
    {
        public static int Main()
        {
            var products = new List<int>();

            for (var a = 1; a <= 99999999; a++)
            {
                if (a.ContainsDigit(0))
                {
                    a = StripOutAllZeros(a) - 1;
                    continue;
                }

                if (!a.IsPandigital())
                {
                    a = StripOutAllDuplicates(a) - 1;
                    continue;
                }
                
                for (var b = 1; b <= 99999999; b++)
                {
                    if (b.ContainsDigit(0))
                    {
                        b = StripOutAllZeros(b) - 1;
                        continue;
                    }

                    if (!b.IsPandigital())
                    {
                        b = StripOutAllDuplicates(b) - 1;
                        continue;
                    }

                    if (TotalConcat(a, b).Length >= 9)
                    {
                        break;
                    }

                    if (!int.Parse(TotalConcat(a, b)).IsPandigital())
                    {
                        b = StripOutAllCrossover(a, b) - 1;
                        continue;
                    }
                    
                    var product = a * b;
                    if (product.ContainsDigit(0) || !product.IsPandigital())
                        continue;
                    
                    var totalConcat = TotalConcat(a, b, product);
                    if (totalConcat.Length == 9 && int.Parse(totalConcat).IsPandigital())
                        products.Add(product);
                }
            }

            return products.Distinct().Sum();
        }

        private static int StripOutAllCrossover(int valueA, int valueB)
        {
            var duplicates = TotalConcat(valueA, valueB).GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
            
            foreach (var dupe in duplicates)
            {
                var dupeIndex = valueB.GetDigitLocation(dupe);
                if (dupeIndex >= 0)
                {
                    var valueToIncrease = (int) Math.Pow(10, dupeIndex);
                    valueB += valueToIncrease;
                    valueB = valueB.RoundToNearest(valueToIncrease);
                }
            }

            return valueB;
        }

        private static int StripOutAllDuplicates(int value)
        {
            while (!value.IsPandigital())
            {
                var duplicates = value.ToString().GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
                foreach (var dupe in duplicates)
                {
                    var dupeIndex = value.GetDigitLocation(dupe);
                    value += (int) Math.Pow(10, dupeIndex);
                }
            }

            return value;
        }

        private static int StripOutAllZeros(int value)
        {
            while (value.ContainsDigit(0))
            {
                var zeroIndex = value.GetDigitLocation('0');
                value += (int) Math.Pow(10, zeroIndex);
            }

            return value;
        }

        private static string TotalConcat(int a, int b, int? product = null)
        {
            return product == null ? string.Concat(a, b) : string.Concat(string.Concat(a, b), product);
        }
    }
}