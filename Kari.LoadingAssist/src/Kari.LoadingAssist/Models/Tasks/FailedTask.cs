using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kari.LoadingAssist.Models.Tasks
{
    public class FailedTask
    {
        /// <summary>
        /// Task ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Occured Error
        /// </summary>
        public Exception Exception { get; set; }

        public FailedTask(Exception exception)
        {
            this.Exception = exception;
        }
    }
}
