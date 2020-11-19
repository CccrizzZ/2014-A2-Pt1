using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonsBehavior : MonoBehaviour
{

    public void NewGameButtonOnPress()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void InstructionButtonOnPress()
    {
        SceneManager.LoadScene("Instruction");

    }
    public void MainMenuButtonOnPress()
    {
        SceneManager.LoadScene("MainMenu");

    }

    

}
