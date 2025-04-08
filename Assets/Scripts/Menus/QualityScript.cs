using UnityEngine;

public class QualityScript : MonoBehaviour
{
    public void ChangeQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
