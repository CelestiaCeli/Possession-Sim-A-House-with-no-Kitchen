using TMPro;
using UnityEngine;
using UnityEngine.Events;
public class Keypad : MonoBehaviour
{
    public UnityEvent Correct;
    string Code = "874";
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CheckIfCorrect(string InputCode)
    {
        if (InputCode == Code)
        {
            Correct.Invoke();
            print("You are correct");
            Destroy(gameObject);
        }
    }
}
