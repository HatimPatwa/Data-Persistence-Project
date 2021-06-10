using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartMenuManager : MonoBehaviour
{
    public static StartMenuManager instance;

    public string nameOfPlayer;
         
    private void Awake()
    {
        if (StartMenuManager.instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ReadTextFromInput(string s)
    {
        nameOfPlayer = s;
        Debug.Log("name entered");
            
    }
    
}
