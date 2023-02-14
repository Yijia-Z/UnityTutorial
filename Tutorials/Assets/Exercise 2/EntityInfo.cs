using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EntityInfo : MonoBehaviour
{
    public bool selected=false;
    public TMP_Text entityHealth;
    public TMP_Text entityName;
    public Material originMaterial , selectedMaterial;
    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            
        }
    }

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            GameObject go = hit.collider.gameObject;
            Debug.Log(go.name);
            if (go == gameObject)
            {
                selected = true;
                entityHealth=GameObject.GetComponent<Health>().ToString;
                return;
            }
        }
        selected=false;
    }
}
