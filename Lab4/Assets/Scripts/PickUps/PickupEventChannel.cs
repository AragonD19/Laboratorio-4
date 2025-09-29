using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Pickup Event Channel")]
public class PickupEventChannel : ScriptableObject
{
    public UnityAction<PickupData> OnPickupCollected;

    public void RaiseEvent(PickupData data)
    {
        OnPickupCollected?.Invoke(data);
    }
}
