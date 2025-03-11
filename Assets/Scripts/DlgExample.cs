using UnityEngine;

public class DlgExample : MonoBehaviour
{
    [SerializeField] string[] dlgLines = new string[3] { "Hello, Adventurer!","Nice day for fishing","Ain't it!"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //foreach
        foreach (string currentLine in dlgLines)
        {
            Debug.Log(currentLine);
        }

        //for
        for (int i = 0; i < dlgLines.Length; i++)
        {
            Debug.Log(dlgLines[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
