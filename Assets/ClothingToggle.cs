using UnityEngine;
using UnityEngine.UI;

public class ClothingToggle : MonoBehaviour
{
    public GameObject[] options;
    private int currentIndex = -1;

    public void NextItem()
    {
        if (currentIndex >= 0) {
            options[currentIndex].SetActive(false);
        }

        currentIndex = (currentIndex + 1) % options.Length;
        options[currentIndex].SetActive(true);

    }

}
