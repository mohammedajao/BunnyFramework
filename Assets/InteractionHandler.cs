using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    public GameObject InteractionZone;
    public string EventName;
    public string TableName;
    public BunnyEventEntry dialogueTrigger;
    // Start is called before the first frame update
    void Start()
    {
        dialogueTrigger = BunnyDialogueManager.Instance.GetEvent(TableName, EventName);
        if(dialogueTrigger != null && dialogueTrigger.IsSatisfied())
        {
            Debug.Log("Can show!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("collision hit" + other.tag);
        // print("trigger satisfied" + dialogueTrigger.IsSatisfied());
        // if(other.tag == "Player" && dialogueTrigger.IsSatisfied())
        // {
        //     dialogueTrigger.Raise<int>(new BunnyBrokerMessage<int>(10, this));
        // }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        print("collision satisfied" + dialogueTrigger.IsSatisfied());
        if(other.gameObject.tag == "Player" && dialogueTrigger != null && dialogueTrigger.IsSatisfied())
        {
             int newID = BunnyDialogueManager.Instance.GetFact("demo", "convo_on_talk_inits").ID;
            dialogueTrigger.Raise();
        } else if(dialogueTrigger != null && !dialogueTrigger.IsSatisfied()) {
            Debug.Log("Dialog conditions not satisfied!");
        }
    }
}
