using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public static Material currentMaterial { get; private set; }
    [SerializeField] private List<Material> colorList;
    public List<Button> colorButtons;

    // Start is called before the first frame update
    void Start()
    {
        currentMaterial = new Material(Shader.Find("Standard"));
        currentMaterial.color = Color.grey;

        foreach (var button in colorButtons)
        {
            button.onClick.AddListener(() => SetGlassesMaterial(button.name));
        }
    }

    void SetGlassesMaterial(string tag)
    {
        SetCurrentColor(tag);

        if (!GlassesChanger.CurrentTag.Equals(""))
        {
            GameObject.FindWithTag(GlassesChanger.CurrentTag).GetComponent<MeshRenderer>().material = currentMaterial;
        }
    }

    void SetCurrentColor(string tag)
    {
        foreach(var color in colorList)
        {
            if (color.name.Equals(tag))
            {
                currentMaterial = color;
            }
        }
    }
}
