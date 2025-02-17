using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goals_PRG281_project
{
    public class GoalManager
    {
        public static List<Goal> GoalList = new List<Goal>();

        public void Add(Goal goal)
        {
            GoalList.Add(goal);
        }
    }
}
