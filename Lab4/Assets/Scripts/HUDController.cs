using UnityEngine;
using UnityEngine.UI; 

public class HUDController : MonoBehaviour
{
    [Header("Referencias UI")]
    public Text healthText;
    public Text armorText;
    public Text scoreText;

    [Header("Referencias Jugador")]
    public PlayerStats playerStats;

    void Update()
    {
        if (playerStats != null)
        {
            healthText.text = "Vida: " + playerStats.currentHealth.ToString();
            armorText.text = "Armadura: " + playerStats.armor.ToString();
        }

        if (ScoreManager.Instance != null)
        {
            scoreText.text = "Score: " + ScoreManager.Instance.GetScore().ToString();
        }
    }
}
