using UnityEngine;
using System.IO;



public class TextSave : MonoBehaviour
{
    string filePath;
    public string[] loadedData;
    public PlayerData player;
    void Start()
    {
        //set values of data
        PlayerData data = new PlayerData
        {
            playerName = "Steve", 
            playerLevel = 51, 
            playerHealthMax = 500, 
            playerCurrentHealth = 250,
            playerPosition = new Vector3(10,1,10), 
            playerRotation = new Vector3(0,90,0)
        };
        //making content into a string
        string saveData = $"{data.playerName}|{data.playerLevel}|{data.playerHealthMax}|{data.playerCurrentHealth}|{data.playerPosition}|{data.playerRotation}";

        filePath = $"{Application.dataPath}/PlayerData.txt";

        // WriteTextFile("This will be content");
        WriteTextFile(saveData);

        Debug.Log(ReadTextFile());
        Load();
    }
    void WriteTextFile(string content)
    {
        File.WriteAllText(filePath, content);
    }
    string ReadTextFile()
    {
        return File.ReadAllText(filePath);
    }

    private void Load()
    {
       loadedData =  ReadTextFile().Split('|');
        player.playerName = loadedData[0];
        player.playerLevel = int.Parse(loadedData[1]);
        player.playerHealthMax = int.Parse(loadedData[2]);
        player.playerCurrentHealth = int.Parse(loadedData[3]);

        string position = loadedData[4].Trim('(');
        position = position.Trim(')');
        string[] values = position.Split(',');
        player.playerPosition.x = float.Parse(values[0]);
        player.playerPosition.y = float.Parse(values[1]);
        player.playerPosition.z = float.Parse(values[2]);
        //

        string rotation = loadedData[5].Trim('(');
        rotation = rotation.Trim(')');
        string[] rotValues = rotation.Split(',');
        player.playerRotation.x = float.Parse(rotValues[0]);
        player.playerRotation.y = float.Parse(rotValues[1]);
        player.playerRotation.z = float.Parse(rotValues[2]);
        //
    }
}
