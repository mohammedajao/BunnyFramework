using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Entries;

[CreateAssetMenu(fileName = "TestExample", menuName = "List Example")]
public class TestExample : ScriptableObject
{
    public List<GummyBaseEntry> entries;
}
