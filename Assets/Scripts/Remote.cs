using UnityEngine;
using UnityEngine.InputSystem;

public class Remote : MonoBehaviour
{
    public GameObject key;
    public GameObject screen;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

   public void ToggleTV()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(key != null)
            {
                key.SetActive(!key.activeSelf);
            }

            if(screen != null)
            {
                screen.SetActive(!screen.activeSelf);
            }
        }
    }
}
