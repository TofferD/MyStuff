using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeStuff
{
    public class HashSet
    {
        public HashSet() 
        { 
            BucketsOfKeys = new List<Tuple<int, List<int>>>();
        }

        public List<Tuple<int, List<int>>> BucketsOfKeys { get; private set; }

        public void Add(int key)
        {
            if (!Contains(key))
            {
                GetBucketFromKey(key).Item2.Add(key);
            }
        }

        public void Remove(int key)
        {
            if (Contains(key))
            {
                GetBucketFromKey(key).Item2.Remove(key);
            }
        }

        public bool Contains(int key)
        {
            List<int> keysInBucket = GetBucketFromKey(key).Item2;
            return keysInBucket.Contains(key);
        }

        private Tuple<int, List<int>> GetBucketFromKey(int key)
        {
            int bucket = key % 10000;
            var bucketTuple = BucketsOfKeys.FirstOrDefault(b => b.Item1 == bucket);

            if (bucketTuple != null)
            {
                return bucketTuple;
            }         

            Tuple<int, List<int>> newBucket = new Tuple<int, List<int>>(bucket, new List<int>());
            BucketsOfKeys.Add(newBucket);
            return BucketsOfKeys[BucketsOfKeys.Count - 1];
        }
    }
}