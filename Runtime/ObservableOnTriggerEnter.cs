using UnityEngine;

public class ObservableOnTriggerEnter : MonoBehaviour
{
    public delegate void EventHandler(Collider other);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnTriggerEnter(Collider other)
    {
        onEvent?.Invoke(other);
    }
}
