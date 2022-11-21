using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jin 
{
    public class JinCoroutine : IEnumerator
    {
        public bool IsDone { get; private set; }
        public bool MoveNext() => !IsDone;
        public object Current { get; }
        public void Reset() {}

        public JinCoroutine(MonoBehaviour owner, IEnumerator coroutine)
        {
            Current = owner.StartCoroutine(Wrap(coroutine));
        }

        private IEnumerator Wrap(IEnumerator coroutine)
        {
            yield return coroutine;
            IsDone = true;
        }
    }
}