using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence Instance;
    public string playerName;
    public string highScorePlayerName;
    public int highScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadData();
    }
    
    [System.Serializable]
    class Data
    {
        public string highScorePlayerName;
        public int highScore;
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);
            
            highScorePlayerName = data.highScorePlayerName;
            highScore = data.highScore;
        }
    }
}
