using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MainUIHandler : MonoBehaviour
{
	public TMP_InputField playerNameInputField;    

    public void StartNew()
    {
		DataPersistence.Instance.playerName = playerNameInputField.text;
        SceneManager.LoadScene(1);
    }
    
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
