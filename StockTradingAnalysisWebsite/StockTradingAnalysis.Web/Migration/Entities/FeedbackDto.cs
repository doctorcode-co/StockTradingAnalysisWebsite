﻿using System;
using StockTradingAnalysis.Domain.Events.Domain;

namespace StockTradingAnalysis.Web.Migration.Entities
{
    [Serializable]
    public class FeedbackDto : Feedback
    {
        public int OldId { get; set; }

        public FeedbackDto()
            : base(Guid.NewGuid())
        {
        }
    }
}
