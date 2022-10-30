using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyGameManager : MonoBehaviour
{
    private BunnyDialogueManager dialogueManager;

    private static BunnyGameManager _instance;

    public static BunnyGameManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
        dialogueManager = BunnyDialogueManager.Instance;
        dialogueManager.Initialize();
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnEnable() {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
