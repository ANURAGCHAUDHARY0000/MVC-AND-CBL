namespace ElectionWinner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candidateVotes = {5,3,4,2};
            int numberOfvotesIncreasedtoEachcandidate = 3;
            PrintElectionResult(ElectionWinnerS2(candidateVotes, numberOfvotesIncreasedtoEachcandidate));
        }

      

        private static int [] ElectionWinnerS2(int[] candidateVotes, int numberOfvotes)
        {
            List<int> votes = candidateVotes.ToList();
           
            for(int i = 0; i < votes.Count; i++)
            {
                for (int j = 0; j < votes.Count; j++)
                {
                    if (votes[i] + numberOfvotes == votes[j])
                    {
                        votes.RemoveAt(j);
                    }
                }
            }

            return votes.ToArray();
        }

        private static void PrintElectionResult(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
    }
}