using System.Data;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{

    public GameObject Keypad;
    GameObject KeypadObject;
    public GameObject KeypadBarrier;

    // Update is called once per frame
    public void KeypadInstantiate()
    {
        KeypadObject = Instantiate(Keypad, new Vector2(0f, 0f), Quaternion.identity);
        KeypadObject.GetComponent<Keypad>().Correct.AddListener(KeyPadUnlock);
    }

   void KeyPadUnlock()
    {
        print("KeypadBarrierDeleted");
        Destroy(KeypadBarrier);
    }
}
