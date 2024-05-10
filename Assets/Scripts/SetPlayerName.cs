using UnityEngine;

public class SetPlayerName : MonoBehaviour
{
    public TextMesh myName;
    public void SetName()
    {
        string textValue = PlayerPrefs.GetString("TextMeshValue");
        myName.text = textValue;
    }
}