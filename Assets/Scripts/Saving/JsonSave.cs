using UnityEngine;
using System.IO;
public class JsonSave : MonoBehaviour
{
    string filePath;
    public PlayerData dataToLoad;

    PlayerData dataToSave = new PlayerData
    {
        playerName = "Kevin",
        playerLevel = 1,
        playerHealthMax = 10,
        playerCurrentHealth = 3,
        playerPosition = new Vector3(0, 1, 0),
        playerRotation = new Vector3(0, 15, 0)
    };

    void Start()
    {
        

        filePath = $"{Application.dataPath}/PlayerData.json";
        SaveJSON(dataToSave);
        dataToLoad = LoadData();
    }
    void SaveJSON(PlayerData data)
    {
        string lineToSave = JsonUtility.ToJson(data);
        File.WriteAllText(filePath, lineToSave);
    }
    PlayerData LoadData()
    {
        string loadedData = File.ReadAllText(filePath);
        return JsonUtility.FromJson<PlayerData>(loadedData);    
    }  
}
