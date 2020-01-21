using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour {
    void Start()
    {       
        GameObject btnObj = GameObject.Find("Play");//"Button"为你的Button的名称  
        Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            this.GoNextScene(btnObj);
        });
    }

    // Update is called once per frame  
    void Update()
    {
    }

    public void GoNextScene(GameObject NScene)
    {
        SceneManager.LoadScene(1);
       // Application.LoadLevel("CarGame");//切换到场景Scene_2  
    }
}