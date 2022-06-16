using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject options;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Options()
    {
        options.GetComponent<Animator>().SetTrigger("open");
    }
    public void CloseOptions()
    {
        options.GetComponent <Animator>().SetTrigger("close");
    }
    public void Quit()
    {
        Application.Quit();
    }

}
