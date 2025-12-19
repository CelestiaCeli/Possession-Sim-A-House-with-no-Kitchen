using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneFunction(int ChangedScene)
    {
        SceneManager.LoadScene(ChangedScene);
    }
}
