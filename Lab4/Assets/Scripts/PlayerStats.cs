using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int armor = 0;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void AddHealth(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        Debug.Log("Vida actual: " + currentHealth);
    }

    public void TakeDamage(int amount)
    {
        int effectiveDamage = Mathf.Max(0, amount - armor);
        currentHealth -= effectiveDamage;
        currentHealth = Mathf.Max(0, currentHealth);
        Debug.Log("Vida tras daño: " + currentHealth);
    }

    public void AddArmor(int amount)
    {
        armor += amount;
        Debug.Log("Armadura actual: " + armor);
    }
}
