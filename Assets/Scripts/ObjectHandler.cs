using Unity.VisualScripting;
using UnityEngine;

public class ObjectHandler : MonoBehaviour
{

    
    public bool IsItemPickuped = false;
    GameObject CollidedPlayer = null;
    Timer Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Timer = this.GetComponent<Timer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (IsItemPickuped)
        {
            this.gameObject.transform.position = new Vector3(CollidedPlayer.transform.position.x, CollidedPlayer.transform.position.y, -10);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        print(collision);
        if (collision.CompareTag("Player"))
        {
            CollidedPlayer = collision.gameObject;
            if (Input.GetKeyDown(KeyCode.R) && Timer.TimerFinished)
            {
                IsItemPickuped = !IsItemPickuped;
                Timer.Activate();
            }
        }

    }
}
