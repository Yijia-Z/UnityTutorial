using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntityInfo : MonoBehaviour
{
    public Text entityNameText;
    public Slider healthBarSlider;
    public Color selectedColor = new Color32(255, 255, 255, 200);

    private Entity selectedEntity;
    public SelectionManager selectionManager;
    public Color originalColor;
    private void Start()
    {}

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
            {   originalColor = selectedEntity.gameObject.GetComponent<Renderer>().material.color;
                // Set the entity's name and health values
                entityNameText.text = selectedEntity.name;
                healthBarSlider.maxValue = selectedEntity.MaxHealth;
                Debug.Log(selectedEntity.name + selectedEntity.Health);
                // Change the entity's color to show it's selected
                selectedEntity.gameObject.GetComponent<Renderer>().material.color = selectedColor;
            }
        }
        if (selectedEntity != null){
            healthBarSlider.value = selectedEntity.Health;
        }else{
            healthBarSlider.value=0;
        }
    }
}