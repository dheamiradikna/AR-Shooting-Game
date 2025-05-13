using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditsPanel;
    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void PlayButtonClicked()
    {
        Application.LoadLevel("Game");
    }

    public void CreditsButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);

    }

    public void Quit_Clicked()
    {
        Application.Quit();
    }

    public void BackButtonClicked()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
    }
}
