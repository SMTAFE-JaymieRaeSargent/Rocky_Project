using UnityEngine;

public class example : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnGUI()
    {
        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                GUI.Box(new Rect(x*(Screen.width/16), y * (Screen.height / 9), 1 * (Screen.width / 16), 1 * (Screen.height / 9)),"");
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
