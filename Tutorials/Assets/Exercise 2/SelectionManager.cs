using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    public LayerMask selectableLayer;

    private Entity selectedEntity = null;
    public SelectionManager(){}

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, selectableLayer))
            {
                Entity entity = hit.collider.GetComponent<Entity>();
                if (entity != null)
                {
                    SelectEntity(entity);
                }
            }
            else
            {
                DeselectEntity();
            }
        }
    }

    private void SelectEntity(Entity entity)
    {
        selectedEntity = entity;
    }

    private void DeselectEntity()
    {
        selectedEntity = null;
    }

    public Entity GetSelectedEntity()
    {
        return selectedEntity;
    }
}
