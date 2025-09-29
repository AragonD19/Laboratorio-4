using UnityEngine;

public class InventoryListener : MonoBehaviour
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
        
        if (data.effectType == PickupEffectType.Unlock || 
            data.effectType == PickupEffectType.AddArmor)
        {
            InventoryUI.Instance.AddItem(data);
        }
    }
}
