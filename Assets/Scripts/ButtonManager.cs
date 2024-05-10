using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public TopDownMovement topDownMovement;

    public GameObject sibeBar;
    public GameObject meruBar;
    public GameObject changeNameBtn;
    public GameObject x_Btn;
    public GameObject hambugar;
    public GameObject newNamePanel;

    public Button button;

    public void StartButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ButtonOff()
    {
        button.interactable = false;
    }
    public void ButtonOn()
    {
        button.interactable = true;
    }
    public void CloseTabBtn()
    {
        sibeBar.SetActive(false);
        meruBar.SetActive(false);
        changeNameBtn.SetActive(false);
        x_Btn.SetActive(false);

        hambugar.SetActive(true);
    }
    public void OnpenTabBtn()
    {
        sibeBar.SetActive(true);
        meruBar.SetActive(true);
        changeNameBtn.SetActive(true);
        x_Btn.SetActive(true);

        hambugar.SetActive(false);
    }

    public void NewName()
    {
        topDownMovement.takeSpeed = 0;
        newNamePanel.SetActive(true);
    }
}
