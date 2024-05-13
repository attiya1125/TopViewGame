using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMessageBtn : MonoBehaviour
{
    public GameObject meesageBtn;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        meesageBtn.SetActive(true);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        meesageBtn.SetActive(false);
    }
}
