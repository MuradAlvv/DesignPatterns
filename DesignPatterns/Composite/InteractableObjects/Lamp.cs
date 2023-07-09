namespace DesignPatterns.Composite.InteractableObjects;

public class Lamp : IInteractable
{
    private bool _enabled;

    private void Switch()
    {
        _enabled = !(_enabled);
    }

    public void Interact()
    {
        Switch();
    }
}