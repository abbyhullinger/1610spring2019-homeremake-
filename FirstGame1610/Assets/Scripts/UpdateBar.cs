using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using Image = UnityEngine.UI.Image;

public class UpdateBar : MonoBehaviour
{
    private Image BarImage;

    public FloatData FillNumber;
    // Start is called before the first frame update
    void Start()
    {
        BarImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        BarImage.fillAmount = FillNumber.Value;
    }
}
