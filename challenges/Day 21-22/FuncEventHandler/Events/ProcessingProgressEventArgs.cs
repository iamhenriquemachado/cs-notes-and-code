using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_21_22.FuncEventHandler.Events
{
    internal class ProcessingProgressEventArgs : EventArgs
    {

        public int PercentComplete { get; }
        public string CurrentBatchName { get; }

        public ProcessingProgressEventArgs(int percentComplete, string currentBatchName)
        {
            PercentComplete = percentComplete;
            CurrentBatchName = currentBatchName;
        }
    }
}
