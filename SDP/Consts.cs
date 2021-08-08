using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP
{
    public static class Consts
    {
        public enum Type
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
    }
}


