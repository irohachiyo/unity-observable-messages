using UnityEngine;

public class ObservableOnTriggerStay : MonoBehaviour
{
    public delegate void EventHandler(Collider other);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnTriggerStay(Collider other)
    {
        onEvent?.Invoke(other);
    }
}
