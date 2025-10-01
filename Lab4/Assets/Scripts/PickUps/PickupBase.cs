using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PickupBase : MonoBehaviour
{
    public PickupData data;
    public PickupEventChannel pickupEventChannel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }

    void Collect()
    {
        pickupEventChannel.RaiseEvent(data);
        Destroy(gameObject);
    }
}
