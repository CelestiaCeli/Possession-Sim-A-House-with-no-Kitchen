using UnityEngine;
using UnityEngine.Events;

public class Doorfunction : MonoBehaviour
{

    public UnityEvent DoorUnlock;
    public GameObject Key; // Assign the key object in the Inspector
    private bool isLocked = true;
    public string DoorTag;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("key") && other.gameObject.GetComponent<Keyfunction>().KeyTag == DoorTag)
        {
            DoorUnlock.Invoke();
            Destroy(gameObject);
            Debug.Log("Door open");
        }
    }
}
