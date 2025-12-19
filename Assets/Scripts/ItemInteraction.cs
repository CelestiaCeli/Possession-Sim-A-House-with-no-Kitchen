using UnityEngine;
using UnityEngine.Events;

public class ItemInteraction : MonoBehaviour
{
    public GameObject GhostObject;
    Ghost GhostScript;
    public UnityEvent InteractedCall;
    bool IsInArea = false;
    bool OneTimeUse = false;

    public UnityEvent InsideTrigger;
    public UnityEvent OutsideTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         GhostScript = GhostObject.GetComponent<Ghost>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R) && IsInArea)
        {
            print("Object Interacted!");
            InteractedCall.Invoke();

        }
    }

    //This has a small bug, fix this later
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && GhostScript.Inspirited == true)
        {
            print("You are in the area.");
            IsInArea = true;
            InsideTrigger.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Ghost") || collision.CompareTag("Player"))
        {
            IsInArea = false;
            OutsideTrigger.Invoke();
        }
    }

    public void SetOneTimeUse(bool Value)
    {
        OneTimeUse = Value;
    }
}
