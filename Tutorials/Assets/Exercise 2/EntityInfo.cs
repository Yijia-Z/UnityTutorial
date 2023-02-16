using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntityInfo : MonoBehaviour
{
    public Text entityNameText;
    public Slider healthBarSlider;
    public Color selectedColor = new Color32(255, 150, 35, 200);

    private Entity selectedEntity;
    public SelectionManager selectionManager;
    private Color originalColor;

    private void Start()
    {
        // Get the original color of the entity
        originalColor = GetComponent<Renderer>().material.color;
    }

    private void Update()
    {
        // Check if the selected entity has changed
        Entity newSelectedEntity = selectionManager.GetSelectedEntity();
        if (newSelectedEntity != selectedEntity)
        {
            // Deselect the previous entity
            if (selectedEntity != null)
            {
                selectedEntity.GetComponent<Renderer>().material.color = originalColor;
            }
            // Select the new entity
            selectedEntity = newSelectedEntity;
            if (selectedEntity != null)
            {
                // Set the entity's name and health values
                entityNameText.text = selectedEntity.name;
                healthBarSlider.value = selectedEntity.Health;
                // Change the entity's color to show it's selected
                selectedEntity.GetComponent<Renderer>().material.color = selectedColor;
            }
        }
    }
}