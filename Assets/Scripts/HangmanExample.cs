using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class HangmanExample : MonoBehaviour
{
    public string[] difficulty;
    public string selectedDifficulty;
    public int selectedDifficultyIndex;

    string filePath;

    public string chosenWord;
    public char[] characters;

    public GameObject characterDisplayPrefab;
    public Transform spawnLocation;
    public Text[] textDisplay;

    private void Start()
    {
        SelectTextFile();
        chosenWord = SplitTextFile(ReadTextFile());
        characters = chosenWord.ToCharArray();
        Debug.Log(characters.Length);
        textDisplay = new Text[characters.Length];
        for (int i = 0; i < characters.Length; i++)
        {
            Text currentLetter = Instantiate(characterDisplayPrefab,spawnLocation).GetComponentInChildren<Text>();
            textDisplay[i] = currentLetter;
        }


        if (chosenWord.Contains('a'))
        {
            foreach (char letter in characters)
            {
                if(letter == 'a')
                {
                    Debug.Log("a was found");
                }
            }
        }
    }
    void SelectTextFile()
    {
        selectedDifficultyIndex = Random.Range(0, difficulty.Length);
        selectedDifficulty = difficulty[selectedDifficultyIndex];
        filePath = $"{Application.dataPath}/{selectedDifficulty}.txt";
        Debug.Log(filePath);
    }
    string ReadTextFile()
    {
        return File.ReadAllText(filePath);
    }
    string SplitTextFile(string words)
    {
        string[] wordsInFile = words.Split('|');
        string chooseWord = wordsInFile[Random.Range(0,wordsInFile.Length)];
        return chooseWord;
    }
}
