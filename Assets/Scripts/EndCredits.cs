using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour {

    public void StartGameButtonClicked()
    {
        //load the next scene.
        SceneManager.LoadScene("End Credits");
    }
}
