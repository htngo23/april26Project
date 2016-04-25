using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepSteak
{
    class Sweepstakes
    {
        string name;
        Random random = new Random();
        class Participant
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int lotteryID { get; set; }
        }

        Dictionary<int, Participant> rost = new Dictionary<int, Participant>()
            {
                { 111, new Participant {FirstName="Mark", LastName="Sanchez", lotteryID=211}},
                { 112, new Participant {FirstName="Huy", LastName="Ngo", lotteryID=212}},
                { 113, new Participant {FirstName="Dwayne", LastName="Wade", lotteryID=213}},
                { 114, new Participant {FirstName="Shane", LastName="Peaches", lotteryID=214}},
                { 115, new Participant {FirstName="Brady", LastName="Thomas", lotteryID=215}},
                { 116, new Participant {FirstName="Connor", LastName="Mcdooder", lotteryID=216}},
            };
        

        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant()
        {

        }
        public string PickWinner()
        {
            int x = random.Next(111,116);
            foreach(KeyValuePair<int, Participant> kvp in rost)
            {
                if (kvp.Key == (x))
                {
                    Console.WriteLine("The winner is: " + kvp.Value.FirstName + " " + kvp.Value.LastName);
                }
                    
            }
            return name;
        }
        public void PrintContestantInfo()
        {

        }
    }
}
