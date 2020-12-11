using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ChangeImageTarget()
    {
        SceneManager.LoadScene("imagetarget");
    }

    public void ChangeCardGame()
    {
        SceneManager.LoadScene("cardgame");
    }

    public void ChangeAdvertisement()
    {
        SceneManager.LoadScene("advertisement");
    }

    public void ChangeVirtualButton()
    {
        SceneManager.LoadScene("VirtualButton");
    }

    public void ChangeMove()
    {
        SceneManager.LoadScene("move");
    }
}
