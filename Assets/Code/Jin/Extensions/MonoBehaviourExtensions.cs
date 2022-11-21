using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin;

public static class MonoBehaviourExtensions
{
    public static JinCoroutine RunCoroutine(
        this MonoBehaviour owner,
        IEnumerator coroutine
    )
    {
        return new JinCoroutine(owner, coroutine);
    }
}
