using UnityEngine;
using UnityEngine.Events;

public class Lamp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool isOn;
    public GameObject item;

    public UnityEvent LampSwitchOn;
    public UnityEvent LampSwitchOff;
    public Sprite LampOff;
    public Sprite LampOn;

    void Start()
    {
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleLamp()
    {
        isOn = !isOn;
        Debug.Log(isOn);
        
        if (isOn)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = LampOn;
            LampSwitchOn.Invoke();
        }
        else 
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = LampOff;
            LampSwitchOff.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ToggleLamp();
        }
    }
}
