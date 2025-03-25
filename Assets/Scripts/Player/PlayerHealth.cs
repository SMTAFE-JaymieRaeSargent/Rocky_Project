namespace Player
{
    using UnityEngine;
    using UnityEngine.UI;
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] float _currentHealth = 100;
        [SerializeField] float _maxHealth = 100;
        [SerializeField] Image _healthBar;
        void Start()
        {
          
           // Damage.Instance.CD(1,2.5f);
        }
        void Update()
        {
            // if the health bar dislay amount is not the same as our current health percentage
            if (_healthBar.fillAmount != Mathf.Clamp01(_currentHealth / _maxHealth))
            {
                //Update Display
                Debug.Log("Controlled");
                _healthBar.fillAmount = Mathf.Clamp01(_currentHealth / _maxHealth);
            }
        }
    }
}