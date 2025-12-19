using UnityEngine;
using UnityEngine.Events;
public class TVRemote : MonoBehaviour
{
    public UnityEvent TVRemoteUse;
    ObjectHandler TVRemoteHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TVRemoteHandler = GetComponent<ObjectHandler>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.T) && TVRemoteHandler.IsItemPickuped)
        {
            TVRemoteUse.Invoke();
        }
    }
}
