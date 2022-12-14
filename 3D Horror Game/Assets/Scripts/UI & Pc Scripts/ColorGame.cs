using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGame : MonoBehaviour
{
    
    ComputerScreen computerScreen;
    public GameObject colorgame;

    public bool game1 = false;
    public bool game2 = false;
    public bool game3 = false;

    public GameObject Showgame1;
    public GameObject Showgame2;
    public GameObject Showgame3;

    public float blue = 0;
    public  float red = 0;
    public  float yellow = 0;
    public float green = 0;

    
    public bool GetGame1()
    {
        return game1;
    }
    public bool GetGame2()
    {
        return game2;
    }
    public bool GetGame3()
    {
        return game3;
    }

    timer Timer;

    void Awake()
    {
        game1 = true;
        computerScreen = GameObject.Find("ComputerScreen").GetComponent<ComputerScreen>();
        Timer = GameObject.Find("TIMER").GetComponent<timer>();
    }
    
    void Update()
    {
        if (Timer.GetREopengame() == true)
        {
            game1 = true;
            game2 = false;
            game3 = false;
        }
        
       

        
        if (computerScreen.GetStartColorgame() == true)
        {
           // game1 = true;
        }
        

        if (game1 == true)
        {
            Showgame1.SetActive(true);
            Showgame2.SetActive(false);
            Showgame3.SetActive(false);
            

            if (game1 == true && blue == 1 && red == 1 && yellow == 1 && green == 1)
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
            game1 = false;
 
        }
        if (game2 == true && blue == 1 && red == 1 && yellow == 1 && green == 1)
        {
            game2 = false;
            Debug.Log("Win2");
          
            game3 = true;

            Showgame2.SetActive(false);
            Showgame3.SetActive(true);
            blue = 0;
            red = 0;
            yellow = 0;
            green = 0;
            

        }

        if (game3 == true)
        {
            Showgame1.SetActive(false);
            Showgame2.SetActive(false);
            Showgame3.SetActive(true);
            game2 = false;
            game1 = false;

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

        if (game1 == false && game2 == false && game3 == false)
        {
            game1 = true;
        }

    }

    public void Blue()
    {
        if (game1 == true)
        {
            if(red == 0 && yellow == 0 && green == 0)
            {
                blue += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }

        }
        
        if (game2 == true)
        {
            if(green == 1 && red == 0 && yellow == 0)
            {
                blue += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }
        }

        if (game3 == true)
        {
            if (green == 1 && red == 0 && yellow == 1)
            {
                blue += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
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
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }

        }
        
        if (game2 == true)
        {
            if(blue == 1 && yellow == 0 && green == 1)
            {
                red += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }

        }

        if (game3 == true)
        {
            if (blue == 1 && yellow == 1 && green == 1)
            {
                red += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
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
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }

        }
       
        if (game2 == true)
        {
            if(blue == 1 && red == 1 && green == 1)
            {
                yellow += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }


        }

        if (game3 == true)
        {
            if (blue == 0 && red == 0 && green == 1)
            {
                yellow += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
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
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }


        }
        
        if (game2 == true)
        {
            if(blue == 0 && yellow == 0 && red == 0)
            {
                green += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }


        }
        if (game3 == true)
        {
            if (blue == 0 && yellow == 0 && red == 0)
            {
                green += 1;
                Sound.PlaySound("Button");
            }
            else
            {
                blue = 0;
                red = 0;
                yellow = 0;
                green = 0;
                Sound.PlaySound("ButtonWrong");
            }


        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }



    

}
