﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.BaseLib
{
    public interface IReviewView
    {
        int CooperationId { get; set; }
        int ReviewScore { get; set; }
        string Comment { get; set; }
    }
}
