using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main
{
   public class Feedback
    {
        public string customerFeedback;
        public int rateFeedback;

        public Feedback()
        {

        }
        public Feedback(string CutomerFeedback, int RateFeedback)
        {
            this.customerFeedback = CutomerFeedback;
            this.rateFeedback = RateFeedback;
        }


        public void ChangeYourFeedback(string ChangedCustomerFeedback)
        {
            this.customerFeedback = ChangedCustomerFeedback;
        }

        public void ChangeYourRankedFeedback(int ChangedrateFeedback)
        {
            this.rateFeedback = ChangedrateFeedback;
        }
    }
}