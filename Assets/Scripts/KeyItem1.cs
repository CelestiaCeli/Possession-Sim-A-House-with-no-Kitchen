using System.Xml.Linq;
using UnityEngine;

public class KeyItem1 : MonoBehaviour
{
    private ObjectHandler Object;
    private GoalContainer BoxContainer;
    public string KeyItemName = "Default";
    private void Start()
    {
        Object = this.GetComponent<ObjectHandler>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Box" && !Object.IsItemPickuped)
        {
            //and the function you just KNOW it's there!
            BoxContainer = collision.gameObject.GetComponent<GoalContainer>();
            ItemRetrieved();
        }
    }
    void ItemRetrieved()
    {
        if (KeyItemName == "VHS")
        {
            Debug.Log("VHS Retrieved");
            BoxContainer.ChangeVHSBool(true);
            Destroy(gameObject);
        }
        else if (KeyItemName == "TeddyBear")
        {
            Debug.Log("Teddy Bear Retrieved");
            BoxContainer.ChangeTeddyBool(true);
            Destroy(gameObject);
        }
        else if (KeyItemName == "Letters")
        {
            Debug.Log("Letters Retrieved");
            BoxContainer.ChangeLettersBool(true);
            Destroy(gameObject);
        }

    }
}

