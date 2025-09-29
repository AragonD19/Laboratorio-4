using UnityEngine;

public class PlayerStatsListener : MonoBehaviour
{
    public PickupEventChannel pickupEventChannel;
    public PlayerStats playerStats;

    private void OnEnable()
    {
        pickupEventChannel.OnPickupCollected += HandlePickup;
    }

    private void OnDisable()
    {
        pickupEventChannel.OnPickupCollected -= HandlePickup;
    }

    void HandlePickup(PickupData data)
    {
        switch (data.effectType)
        {
            case PickupEffectType.Heal:
                playerStats.AddHealth(data.value);
                break;

            case PickupEffectType.Damage:
                playerStats.TakeDamage(data.value);
                break;

            case PickupEffectType.AddArmor:
                playerStats.AddArmor(data.value);
                break;
        }
    }
}
