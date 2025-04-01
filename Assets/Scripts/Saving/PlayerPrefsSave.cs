using UnityEngine;

public class PlayerPrefsSave : MonoBehaviour
{
    public string playerName;
    public float currentHealth;
    public int level;
    void Save()
    {
        PlayerPrefs.SetString("CharacterName", playerName);
        PlayerPrefs.SetFloat("CurrentHealth",currentHealth);
        PlayerPrefs.SetInt("Level",level);
    }
    private void Load()
    {
        if (PlayerPrefs.HasKey("CharacterName"))
        {
            playerName = PlayerPrefs.GetString("CharacterName");
            currentHealth = PlayerPrefs.GetFloat("CurrentHealth");
            level = PlayerPrefs.GetInt("Level");
        }       
        
    }
    void Delete()
    {
        PlayerPrefs.DeleteKey("CurrentHealth");
        PlayerPrefs.DeleteAll();

    }
}
