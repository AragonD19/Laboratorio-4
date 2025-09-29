using UnityEngine;

public class ScoreListener : MonoBehaviour
{
    public PickupEventChannel pickupEventChannel;

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
        if (data.effectType == PickupEffectType.AddScore)
        {
            ScoreManager.Instance.AddScore(data.value);
        }
    }
}
