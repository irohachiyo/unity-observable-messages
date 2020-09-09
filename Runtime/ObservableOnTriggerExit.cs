using UnityEngine;

public class ObservableOnTriggerExit : MonoBehaviour
{
    public delegate void EventHandler(Collider other);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnTriggerExit(Collider other)
    {
        onEvent?.Invoke(other);
    }
}
