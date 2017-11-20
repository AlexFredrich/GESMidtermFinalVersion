using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnToTitle : MonoBehaviour {

    public void StartGameButtonClicked()
    {
        //load the next scene.
        SceneManager.LoadScene("Title Scene");
    }

}
