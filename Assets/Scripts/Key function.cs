using UnityEngine;

public class Keyfunction : MonoBehaviour
{
    public bool keyCollected = false;
    public GameObject itemToToggle;
    public string KeyTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            keyCollected = true;
            Debug.Log("Key collected!");
        }
    }
}
