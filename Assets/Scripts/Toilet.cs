using UnityEngine;

public class Toilet : MonoBehaviour
{
    public GameObject VHSTape;
    private bool isPlayerNearby = false;


    private void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.R))
        {
            GiveItem();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Players"))
        {
            isPlayerNearby = true;
            Debug.Log("Press R to flush");
        }
    }

    private void GiveItem()
    {

        Debug.Log("VHSTape collected!");
    }

}
