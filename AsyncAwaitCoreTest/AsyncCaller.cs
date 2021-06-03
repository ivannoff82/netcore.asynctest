using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitCoreTest
{
    /// <summary>
    /// Async demo class
    /// </summary>
    public class AsyncCaller
    {
        /// <summary>
        /// Indexer of long operation
        /// </summary>
        public int Number;

        /// <summary>
        /// Is increase in progress
        /// </summary>
        public bool InProcess = false;

        /// <summary>
        /// Fake long operation
        /// </summary>
        private void IncreaseNumberInner()
        {
            InProcess = true;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Number = i;                
            }
            InProcess = false;
        }
        
        /// <summary>
        /// ctor
        /// </summary>
        public AsyncCaller()
        {
            Number = 0;
        }

        /// <summary>
        /// Public async call of fake long operation
        /// </summary>
        public async void IncreaseNumber()
        {
            //Cal async as function
            await Task.Run(() => IncreaseNumberInner());
        }
    }
}
