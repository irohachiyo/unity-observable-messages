using UnityEngine;

public class ObservableOnCollisionEnter : MonoBehaviour
{
    public delegate void EventHandler(Collision collision);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnCollisionEnter(Collision collision)
    {
        onEvent?.Invoke(collision);
    }
}
