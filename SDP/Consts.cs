using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP
{
    public static class Consts
    {
        public enum PTypes
        {
            EDP,
            EDT
        };
        public enum Status
        {
            pendingAction,
            beingDelivered,
            deliveryComplete
        };
        public enum CataTypes
        {
            promotion,
            product,
            article
        };
    }
}


