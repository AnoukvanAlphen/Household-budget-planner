using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goals_PRG281_project
{
    
        public class Goal
        {
        public Goal(String name, decimal targetAmount, decimal currentProgress, DateTime deadline)
        {
            Name = name;
            TargetAmount = targetAmount;
            CurrentProgress = currentProgress;
            Deadline = deadline;

        }

        public string Name { get => name; set => name = value; }
            public decimal TargetAmount { get => targetAmount; set => targetAmount = value; }
            public decimal CurrentProgress { get => currentProgress; set => currentProgress = value; }
            public DateTime Deadline { get => deadline; set => deadline = value; }


      
        private string name;
            private decimal targetAmount;
            private decimal currentProgress;
            private DateTime deadline;
        }


    }

