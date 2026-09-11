using UnityEngine;
using TMPro;

public class CategoryReader : MonoBehaviour
{
    public TextAsset jsonFile;
    public TMP_Text categoryText;
    [Range(0, 5)]
    public int categoryIndex;


    void Category()
    {
        Categories categoriesInJson = JsonUtility.FromJson<Categories>(jsonFile.text);

        if (categoryIndex < categoriesInJson.categories.Length)
        {
            categoryText.text = categoriesInJson.categories[categoryIndex].category;
        }
    }

    private void Start()
    {
        Category();
    }
}