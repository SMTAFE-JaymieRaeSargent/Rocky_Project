namespace NPC
{
    //creating choice yes no 
    //approval system 

    using UnityEngine;
    using UnityEngine.UI;
    public class LinearDlg : MonoBehaviour
    {
        [SerializeField] string[] _linesOfDialogue = new string[5];
        [SerializeField] Text _dialogueDisplay;
        [SerializeField] int _index = 0;
        [SerializeField] Text _buttonDisplay;
        [SerializeField] GameObject _dialoguePanel;
        void Start()
        {
            _dialogueDisplay.text = _linesOfDialogue[_index];
            //Button text say Next
            _buttonDisplay.text = "Next";
        }
        public void Next()
        {
            if (_index < _linesOfDialogue.Length-1)
            {
                _index++;
                _dialogueDisplay.text = _linesOfDialogue[_index];
                if (_index >= _linesOfDialogue.Length - 1)
                {
                    //Button text to say Bye.
                    _buttonDisplay.text = "Bye.";
                }
            }  
            else
            {
                _dialoguePanel.SetActive(false);
            }
        }
    }
}