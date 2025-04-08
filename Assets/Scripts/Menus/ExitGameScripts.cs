using UnityEngine;

public class ExitGameScripts : MonoBehaviour
{
    public void ExitToDesktop()
    {
#if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();

    }
}
