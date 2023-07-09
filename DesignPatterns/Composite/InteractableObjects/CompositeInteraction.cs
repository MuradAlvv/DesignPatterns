namespace DesignPatterns.Composite.InteractableObjects;

public class CompositeInteraction : IInteractable
{
    private readonly List<IInteractable> _interactableObjects;

    public CompositeInteraction()
    {
        _interactableObjects = new List<IInteractable>();
    }

    public void Interact()
    {
        _interactableObjects.ForEach(obj => obj.Interact());
    }

    public void Add(IInteractable child)
    {
        _interactableObjects.Add(child);
    }
}