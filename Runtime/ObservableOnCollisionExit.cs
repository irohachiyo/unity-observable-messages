using UnityEngine;

public class ObservableOnCollisionExit : MonoBehaviour
{
    public delegate void EventHandler(Collision collision);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnCollisionExit(Collision collision)
    {
        onEvent?.Invoke(collision);
    }
}
