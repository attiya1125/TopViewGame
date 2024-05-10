using UnityEngine;

public class SetPlayerName : MonoBehaviour
{
    public TextMesh myName;
    public void SetName()
    {
        myName.text = PlayerPrefs.GetString("TextMeshValue");
    }
}