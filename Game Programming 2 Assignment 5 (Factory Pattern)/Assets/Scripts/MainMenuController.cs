using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public GameObject menuButtons;

    // Start is called before the first frame update
    void Start()
    {
        menuButtons.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel(string level)
    {
        switch(level)
        {
            case "Level 1":
                SceneManager.LoadSceneAsync(1);
                break;
        }
    }

}
;