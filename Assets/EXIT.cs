using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXIT : MonoBehaviour
{
    void Start()
    {
        GameObject btnObj = GameObject.Find("Exit");//"Button"为你的Button的名称  
        Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            this.ExitGame(btnObj);
        });
    }

    // Update is called once per frame  
    void Update()
    {
    }

    public void ExitGame(GameObject NScene)
    {
        Application.Quit();
    }
}