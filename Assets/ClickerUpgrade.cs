using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickerUpgrade : MonoBehaviour
{
    [Serializable]
    public struct ClickerUpgradeOptions
    {
        public string name;
        public string description;
        public int value;
        public int price;
        public bool isAuto;
        public Text UI;
        public Button button;
    }
    public ClickerUpgradeOptions[] options;
    public ClickerManager manager;

    public void Upgrade(int index)
    {
        if (manager.score >= options[index].price)
        {
            manager.SetPrice(options[index].isAuto, options[index].value, options[index].price);
            options[index].value++;
            options[index].price *= 2;
        }
    }
}
