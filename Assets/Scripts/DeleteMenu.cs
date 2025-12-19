using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class DeleteMenu : MonoBehaviour
{
    public void Delete()
    {
        Destroy(gameObject);
    }
}
