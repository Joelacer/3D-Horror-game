using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGame : MonoBehaviour
{
    
    ComputerScreen computerScreen;
    public GameObject colorgame;

    bool game1 = false;
    bool game2 = false;
    bool game3 = false;

    public GameObject Showgame1;
    public GameObject Showgame2;
    public GameObject Showgame3;

    public float blue = 0;
    public  float red = 0;
    public  float yellow = 0;
    public float green = 0;


    void Awake()
    {

        computerScreen = GameObject.Find("ComputerScreen").GetComponent<ComputerScreen>();
    }

    void Update()
    {
        
        
        if (computerScreen.GetStartColorgame() == true)
        {
            game1 = true;
        }
        else
        {
            game1 = false;
            game3 = false;
            game2 = false;
        }


        if (game1 == true)
        {
            Showgame1.SetActive(true);
            Showgame2.SetActive(false);
            Showgame3.SetActive(false);
            

            if (blue == 1 && red == 1 && yellow == 1 && green == 1)
            {
                game1 = false;
                game3 = false;
                game2 = true;
                Showgame2.SetActive(true);
                Showgame1.SetActive(false);
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }
        }

        if (game2 == true)
        {
            Showgame1.SetActive(false);
            Showgame2.SetActive(true);
            Showgame3.SetActive(false);


            if (blue == 1 && red == 1 && yellow == 1 && green == 1)
            {
                game1 = false;
                game3 = true;
                game2 = false;
                Showgame2.SetActive(false);
                Showgame3.SetActive(true);
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;

            }
        }

        if (game3 == true)
        {
            Showgame1.SetActive(false);
            Showgame2.SetActive(false);
            Showgame3.SetActive(true);

            if (blue == 1 && red == 1 && yellow == 1 && green == 1)
            {
                game1 = false;
                game3 = false;
                game2 = false;
                Showgame2.SetActive(false);
                Showgame3.SetActive(false);
                Showgame1.SetActive(false);
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;

                colorgame.SetActive(false);
            }
        }


    }

    public void Blue()
    {
        if (game1 == true)
        {
            if(red == 0 && yellow == 0 && green == 0)
            {
                blue += 1;
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }

        }
        
        if (game2 == true)
        {
            if(green == 1 && red == 0 && yellow == 0)
            {
                blue += 1;
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }
        }
       
    }

    public void Red()
    {
        if (game1 == true)
        {
            if(blue == 1 && yellow == 1 && green == 1)
            {
                red += 1;
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }

        }
        
        if (game2 == true)
        {
            if(blue == 1 && yellow == 0 && green == 1)
            {
                red += 1;
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }

        }
        
    }

    public void Yellow()
    {
        if(game1 == true)
        {
            if(blue == 1 && red == 0 && green == 1)
            {
                yellow += 1;
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }

        }
       
        if (game2 == true)
        {
            if(blue == 1 && red == 1 && green == 1)
            {
                yellow += 1;
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }

        }
        
    }

    public void Green()
    {
        if(game1 == true)
        {
            if(blue == 1 && yellow == 0 && red == 0)
            {
                green += 1;
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }


        }
        
        if (game2 == true)
        {
            if(blue == 0 && yellow == 0 && red == 0)
            {
                green += 1;
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
            }


        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }



    

}
