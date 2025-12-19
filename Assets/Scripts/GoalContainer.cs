using UnityEngine;

public class GoalContainer : MonoBehaviour
{
    bool TeddyBearCollected = false;
    bool LettersCollected = false;
    bool VHSCollected = false;


    public GameObject Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
     void CheckUp()
    {
        if(TeddyBearCollected && LettersCollected && VHSCollected)
        {
            Door.SetActive(false);
        }
    }

    public void ChangeTeddyBool(bool status)
    {
        TeddyBearCollected = status;
        CheckUp();
    }
    public void ChangeLettersBool(bool status)
    {
        LettersCollected = status;
        CheckUp();
    }
    public void ChangeVHSBool(bool status)
    {
        VHSCollected = status;
        CheckUp();
    }

}
