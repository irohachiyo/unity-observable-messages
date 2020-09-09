using UnityEngine;

public class ObservableOnTriggerStay2D : MonoBehaviour
{
    public delegate void EventHandler(Collider2D collision);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        onEvent?.Invoke(collision);
    }
}
