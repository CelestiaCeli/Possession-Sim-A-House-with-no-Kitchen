using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject[] Player;
    GameObject SelectedPlayer;
    int i = 0;
    void Start()
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        Player = GameObject.FindGameObjectsWithTag("Players");

        for (int i = 0; i < Player.Length; i++)
        {
            if (Player[i].GetComponent<CharacterManager>().IsSelected)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Player = GameObject.FindGameObjectsWithTag("Players");

            for (int i = 0; i < Player.Length; i++)
            {
                if (Player[i].GetComponent<CharacterManager>().IsSelected)
                {
                    SelectedPlayer = Player[i];
                    break;
                }
            }


        }

        for (int i = 0; i < Player.Length; i++)
        {
            if (Player[i].GetComponent<CharacterManager>().IsSelected)
            {
                SelectedPlayer = Player[i];
                break;
            }
        }
        Debug.Log(SelectedPlayer);
        this.gameObject.transform.position = SelectedPlayer.transform.position;
    }
}
