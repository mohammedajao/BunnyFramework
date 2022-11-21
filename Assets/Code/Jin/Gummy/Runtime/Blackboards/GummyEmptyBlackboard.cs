using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jin.Gummy.Blackboard
{
    public class GummyEmptyBlackboard : GummyBlackboard
    {
        private static GummyEmptyBlackboard _blackboard;

        public static GummyEmptyBlackboard Instance 
        {
            get
            {
                if(_blackboard == null)
                {
                    _blackboard = new GummyEmptyBlackboard();
                }
                return _blackboard;
            }
        }
    }
}
