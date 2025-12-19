using UnityEngine;
using UnityEngine.Events;

public class TriggerSend : MonoBehaviour
{
    public UnityEvent GrassEvent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GrassEvent.Invoke();
        }
    }
}
