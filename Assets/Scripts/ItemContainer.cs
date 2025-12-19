using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    public float DimensionX = 9.4f;
    public float DimensionY = 7.2f;
    public GameObject Item;
    bool ItemOut = false;

    public void ItemOutput(bool SingleUse)
    {
        if (!ItemOut)
        {
            Instantiate(Item, new Vector2(DimensionX, DimensionY), Quaternion.identity);
            ItemOut = SingleUse;
        }
    }
}
