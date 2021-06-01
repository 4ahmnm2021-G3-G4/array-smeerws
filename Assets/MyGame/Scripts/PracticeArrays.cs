using UnityEngine;
using UnityEngine.UI;

public class PracticeArrays : MonoBehaviour
{
    //Deklaration eines Arrays namens array vom Datentyp int
    int[] array;
    //public GameObject[] arrayColoredImagesRed;


    private void Start()
    {
        //Deklaration von array1, array2, array3. array4 und deren Initialiserung auf 3 unterschiedliche Arten:
        // -- array1 Datentyp int, 4 Elemente
        int[] array1 = new int[4];

        // -- array2 Datentyp int, 4 Elemente, Werte 21,22,23,24
        int[] array2 = new int[] { 21, 22, 23, 24 };

        // -- array3 Datentyp int, 7 Elemente, Werte 31-37
        int[] array3 = { 31, 32, 33, 34, 35, 36, 37};

        // -- array4 Datentyp string, 10 Elemente, Werte "array4"
        string[] array4 = new string[10];
        for (int i = 0; i < 10; i++)
        {
            array4[i] = "array4";
        }

        // -- arrayColoredImagesRed Datentyp GameObject mittels GameObject.FindGameObjectsWithTag("RedImage"); dabei ist natürlich Voraussetzung, dass die Images im 2D Unity Projekt angelegt sind (4 Elemente) und das Tag RedImage jeweils ausgewählt ist.
        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
        
        foreach(GameObject i in arrayColoredImagesRed)
        {
            Debug.Log(i.name);
        }

        //Direkter Zugriff auf einzelne Elemente in den Arrays array1-array4 und arrayColoredImageRed
        Debug.Log("array1[0]= " + array1[0]);
        Debug.Log("array2[0]= " + array2[0]);
        Debug.Log("array3[0]= " + array3[0]);
        Debug.Log("array4[0]= " + array4[0]);

        Debug.Log("array1[" + (array1.Length - 1) + "]= " + array1[array1.Length - 1]);
        Debug.Log("array2[" + (array2.Length - 1) + "]= " + array2[array2.Length - 1]);
        Debug.Log("array3[" + (array3.Length - 1) + "]= " + array3[array3.Length - 1]);
        Debug.Log("array4[" + (array4.Length - 1) + "]= " + array4[array4.Length - 1]);

        // 1) auf erstes Element -- Jeweils ein Debug.Log ausgeben. Beim arrayColoredImageRed den Namen des Objektes ausgeben.
        Debug.Log(arrayColoredImagesRed[0].name);

        // 2) auf letzes Element -- Jeweils ein Debug.Log ausgeben. Beim arrayColoredImageRed den Namen des Objektes ausgeben.
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length-1].name);

        //Zugriff auf einen Array mittels For-Schleife. Eine For-Schleife führt eine Operation mehrmals aus.

        //Hier wird immer wieder der Wert der Elemente als string im Array in einem Debug.Log ausgegeben.

        //1) Eine Methode schreiben die die Werte mit zugehörigen index als Debug.Log ausgibt.

        // Element[0] = Wert an 0

        // Element[1] = Wert an 1

        PrintArrayWithIndex(array1);
        PrintArrayWithIndex(array4);
        PrintArrayWithIndex(arrayColoredImagesRed);

        //2) Eine Methode schreiben die die Werte des Arrays als einen langen string ausgibt, z.b. 1 2 3 4 statt
        PrintArrayAsOneliner(array2);
        PrintArrayAsOneliner(array4);

        //Array Zugriff einzelne Elemente:

        //Greifen Sie auf das 4te Elemente in array1 zu und ändern sie den Wert auf 3. Geben Sie das Element mittels Debug.Log aus
        array1[3] = 3;
        Debug.Log(array1[3]);

        //Greifen Sie auf das 3te Element in array2 zu und ändern sie den Wert auf 203. Geben Sie das Element mittels Debug.Log aus
        array2[2] = 203;
        Debug.Log(array2[2]);

        //Greifen Sie auf das 6te Element in array3 zu und ändern sie die Farbe auf 333.
        array3[5] = 333;
        Debug.Log(array3[5]);

        //Greifen Sie auf das 3te Element in array4 zu und ändern sie den Wert auf "heute". Geben Sie das Element mittels Debug.Log aus
        array4[2] = "heute";
        Debug.Log(array4[2]);

        //Greifen Sie auf das 3te Element in arrayColoredImagesRed zu und ändern sie die Farbe auf grün. Die Änderung sollte in der Scene/Game View ersichtlich sein
        arrayColoredImagesRed[2].GetComponent<Image>().color = Color.green;
        Debug.Log(arrayColoredImagesRed[2].GetComponent<Image>().color.ToString());

        //Erstelle ein weiteres Array mit Namen array5, dass mit allen geraden Zahlen zwischen 20 und 70 gefüllt ist.
        
        int[] array5 = new int[GetFrequencyNumbers(20,70,"even")];
 
        int numbers5 = 0;
        for (int i = 20; i <= 70; i++)
        {
            if (i % 2 == 0)
            {
                array5[numbers5] = i;
                numbers5++;
            }
        }

        PrintArrayWithIndex(array5);

        //Gefordert ist ein Array mit Namen array6, dass alle geraden Zahlen zwischen 0 und 500 enthält.
        int[] array6 = new int[GetFrequencyNumbers(0, 500, "even")];

        int numbers6 = 0;
        for (int i = 0; i <= 500; i++)
        {
            if (i % 2 == 0)
            {
                array6[numbers6] = i;
                numbers6++;
            }
        }

        PrintArrayWithIndex(array6);

        //Gefordert ist ein Array mit Namen array7, dass alle ungeraden Zahlen zwischen 0 und 500 enthält.
        int[] array7 = new int[GetFrequencyNumbers(0, 500, "odd")];

        int numbers7 = 0;
        for (int i = 0; i <= 500; i++)
        {
            if (i % 2 != 0)
            {
                array7[numbers7] = i;
                numbers7++;
            }
        }

        PrintArrayWithIndex(array7);

        //Gefordert ist ein Array mit Namen array8, dass 100 Elemente hält und als Elemente folgende Buchstabenreihe hat: "a", "b", "a", "b","a", "b","a", "b", ...
        string[] array8 = new string[100];
        for (int i = 0; i < 100; i++)
        {
            if(i%2 == 0)
            {
                array8[i] = "a";
            }
            else
            {
                array8[i] = "b";
            }
        }

        PrintArrayAsOneliner(array8);

        //Gefordert ist ein Array mit Namen array9, mit 1000 Elementen. Die Elemente werden mit Randomzahlen gefüllt und ausgegeben über Debug.
        int[] array9 = new int[1000];
        for (int i = 0; i < array9.Length; i++)
        {
            array9[i] = Random.Range(0, 20);
        }

        PrintArrayWithIndex(array9);

        //Das array9 einhält unsortierte int Werte. Sortiere das Array und gib mittels Debug.Log die Werte des sortierten array9 aus. HINT: Hier wird System.Array.Sort() verwendet!!

        System.Array.Sort(array9);

        PrintArrayAsOneliner(array9);

        //Erweitern des Array durch zusammenkopieren von 2 Arrays. Kopiere array5 und arry6 in ein neues array10
        int[] array10 = new int[array5.Length + array6.Length];
        array5.CopyTo(array10, 0);
        array6.CopyTo(array10, array5.Length);
        PrintArrayAsOneliner(array10);

        //Gefordert ist ein Array mit Namen array11, mit 1000 Elementen. Die Elemente werden mit Randomzahlen gefüllt, ermittle das Minimum und Maximum der enthaltenen Werte.
        int[] array11 = new int[1000];
        for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = Random.Range(0, 1000);
        }

        System.Array.Sort(array11);
        Debug.Log("min array11 = " + array11[0]);
        Debug.Log("max array11 = " + array11[array11.LongLength-1]);

        //Gefordert ist ein Array mit Namen array12, mit 1000 Elementen. Die Elemente werden mit Randomzahlen gefüllt. Suche einen Wert und gib den Index retour, Hint: System.Array nachschauen!
        int[] array12 = (int[])array11.Clone();
        Debug.Log("Index of value: " + System.Array.IndexOf(array12, 22));

        //optional: Histogram: Gefordert ist ein Array mit Namen array13. Die Elemente werden mit Randomzahlen gefüllt zwischen 1 und 5. Ermittle wie oft 1, 2, 3, 4, 5 vorkommt und speichere die Anzahl in einem Array namens histogram. Das Array histogram hat 5 Elemente.
        int[] array13 = new int[30];
        for(int i = 0; i < array13.Length; i++)
        {
            array13[i] = Random.Range(1,6);
        }

        int[] histogram = new int[5];
        for (int i = 0; i < array13.Length; i++)
        {
            if (array13[i] == 1)
            {
                histogram[0] += 1;
            }
            else if (array13[i] == 2)
            {
                histogram[1] += 1;
            }
            else if (array13[i] == 3)
            {
                histogram[2] += 1;
            }
            else if (array13[i] == 4)
            {
                histogram[3] += 1;
            }
            else if (array13[i] == 5)
            {
                histogram[4] += 1;
            }
        }
        System.Array.Sort(array13);
        PrintArrayAsOneliner(array13);
        PrintArrayAsOneliner(histogram);

    }

    int GetFrequencyNumbers(int min, int max, string evenOdd)
    {
        int freq = 0;

        for (int i = min; i <= max; i++)
        {
            if (evenOdd == "even")
            {
                if(i % 2 == 0)
                {
                    freq++;
                }
            }else if(evenOdd == "odd" )
            {
                if(i % 2 != 0)
                {
                    freq++;
                }
            }
        }
        return freq;
    }


    void PrintArrayAsOneliner(int[] array)
    {
        string tmp = "";
        for(int i = 0; i < array.Length;  i++)
        {
            tmp = tmp + array[i].ToString();

            if (i != array.Length - 1)
            {
                tmp = tmp + ", ";
            }
        }

        Debug.Log(tmp);
    }

    void PrintArrayAsOneliner(string[] array)
    {
        string tmp = "";
        for(int i = 0; i < array.Length; i++)
        {
            tmp = tmp + array[i];

            if (i != array.Length - 1)
            {
                tmp = tmp + ", ";
            }
        }

        Debug.Log(tmp);
    }

    void PrintArrayWithIndex(int[] array)
    {
        for(int i=0;i<array.Length;i++)
        {
            Debug.Log("Element[" + i + "] = "+ array[i]);
        }
    }

    void PrintArrayWithIndex(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element[" + i + "] = " + array[i]);
        }
    }

    void PrintArrayWithIndex(GameObject[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element[" + i + "] = " + array[i].name);
        }
    }

}