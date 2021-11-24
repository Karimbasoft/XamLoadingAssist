using Kari.LoadingAssist.Models.LoadingAssist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kari.LoadingAssist.Service.LoadingAssist
{
    public class LoadingAssist : ILoadingAssist
    {
        /// <inheritdoc/>
        public bool IsAnimationRunning { get; set; }

        /// <inheritdoc/>
        public void CloseLoadingScreen()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void ShowLoadingScreen(string loadingDisplayText, CancellationToken cancellationToken, string animationSourceName = "", bool displayAsPopUp = false)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void ShowLoadingScreen(string loadingDisplayText, bool displayAsPopUp = false)
        {
            
        }
    }
}
