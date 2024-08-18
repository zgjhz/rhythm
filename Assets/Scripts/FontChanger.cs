using UnityEngine;
using TMPro;  // ��������� ������������ ��� ��� TextMeshPro

public class FontChanger : MonoBehaviour
{
    public TMP_FontAsset newFont;  // ���� ��� ������ ������ Text Mesh Pro

    void Start()
    {
        // ������� ��� ������� � ����������� TMP_Text (�������� ��� ��� UI, ��� � ��� ������� �������)
        TMP_Text[] texts = FindObjectsOfType<TMP_Text>();

        // ���������� �� ���� ��������� �������� � ������ �����
        foreach (TMP_Text text in texts)
        {
            text.font = newFont;  // ����������� ����� �����
        }

        Debug.Log("Font changed for all TextMeshPro components.");
    }
}