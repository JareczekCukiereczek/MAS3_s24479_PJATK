namespace MAS3;

public class Library
{
    private List<Material> materials = new List<Material>();

    public void AddMaterial(Material material)
    {
        materials.Add(material);
    }
}