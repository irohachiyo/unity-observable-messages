using UnityEngine;

public class ObservableOnCollisionStay : MonoBehaviour
{
    public delegate void EventHandler(Collision collision);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnCollisionStay(Collision collision)
    {
        onEvent?.Invoke(collision);
    }
}
