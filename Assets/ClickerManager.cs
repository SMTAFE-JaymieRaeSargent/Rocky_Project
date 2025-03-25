using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
    //Value Per Click
     [SerializeField]int clickValue = 1;
    //Score
    public float score = 0;
    //UI Display for Score
    [SerializeField] Text _scoreDisplay;
    //increase over time
    [SerializeField] int valueOverTime = 0;
    //timer
    [SerializeField] float timer = 0;
    private void Update()
    {
        if (valueOverTime > 0)
        {
            timer += Time.deltaTime;
            if (timer > 1)
            {
                score += valueOverTime;
                UpdateUI();
                timer = 0;
            }
        }
    }

    //Main Click Button Behaviour
    public void Click()
    {
        //Increases Score by Click Value
        score += clickValue;
        UpdateUI();
    }
    public void UpdateUI()
    {
        //Updates UI
        _scoreDisplay.text = $"{score:C0}";
    }

    public void SetPrice(bool isAuto, int value, int price)
    {
        if (isAuto)
        {
            valueOverTime += value;
        }
        else
        {
            clickValue += value;
        }
        score -= price;
        UpdateUI();
    }
}
