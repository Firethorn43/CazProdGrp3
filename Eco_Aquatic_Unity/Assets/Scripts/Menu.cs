using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button newGameButton;
    public string newGameSceneName;
    public bool isPlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {
        /*if (isQuit)
        {
            //Application.Quit();
        }*/
        if (isPlay)
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameSceneName);
    }

    public void QuitGame()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
