using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19
{
    class Online_Election
    {
        public class TopVotedCandidate
        {

            int[] times;
            Dictionary<int, int> current_tops;

            public TopVotedCandidate(int[] persons, int[] times)
            {
                this.times = times;
                current_tops = new Dictionary<int, int>();
                Dictionary<int, int> vote_counter = new Dictionary<int, int>();

                int top_person = 0;
                int top_counter = 0;

                int i = 0;
                foreach (int person in persons)
                {
                    try
                    {
                        vote_counter[person]++;
                    }
                    catch
                    {
                        vote_counter.Add(person, 1);
                    }

                    if (vote_counter[person] >= top_counter)
                    {
                        top_counter = vote_counter[person];
                        top_person = person;
                    }

                    current_tops.Add(i, top_person);
                    i++;
                }

            }

            public int Q(int t)
            {
                int timeIdx = Array.BinarySearch(times, t);
                if (timeIdx < 0) timeIdx = ~timeIdx - 1;
                return current_tops[timeIdx];
            }
        }

        /**
         * Your TopVotedCandidate object will be instantiated and called as such:
         * TopVotedCandidate obj = new TopVotedCandidate(persons, times);
         * int param_1 = obj.Q(t);
         */
    }
}
