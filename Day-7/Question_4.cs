using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_7
{
    class Question_4
    {
        public int[] RearrangeBarcodes(int[] barcodes)
        {
            Dictionary<int, int> barcode = new Dictionary<int, int>();
            for (int i = 0; i < barcodes.Length; i++)
            {
                if (barcode.ContainsKey(barcodes[i])) barcode[barcodes[i]]++;
                else barcode.Add(barcodes[i], 1);
            }
            var keys = barcode.Keys.OrderBy(key => barcode[key]);

            var index = 1;
            foreach (var key in keys)
            {
                int occurence = barcode[key];
                for (int i = 0; i < occurence; i++)
                {
                    if (index >= barcodes.Length)
                    {
                        index = 0;
                    }
                    barcodes[index] = key;
                    index += 2;
                }
            }
            return barcodes;
        }
    }
}
