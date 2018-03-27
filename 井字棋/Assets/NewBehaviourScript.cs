using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    public GUISkin Player1;
    public GUISkin Player2;
    public GUISkin Customer;
    public string message = "轮到player1";
    public string string1 = "";
    public string string2 = "";
    public string string3 = "";
    public string string4 = "";
    public string string5 = "";
    public string string6 = "";
    public string string7 = "";
    public string string8 = "";
    public string string9 = "";
    int[] player1 = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] player2 = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int count1 = 0;
    int count2 = 0;
    int[] selected = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    //public GUISkin mySkin;
    bool Adjust(int[] player)
    {
        if (player[1] == 1 && player[2] == 1 && player[3] == 1)
            return true;
        if (player[4] == 1 && player[5] == 1 && player[6] == 1)
            return true;
        if (player[7] == 1 && player[8] == 1 && player[9] == 1)
            return true;
        if (player[1] == 1 && player[4] == 1 && player[7] == 1)
            return true;
        if (player[2] == 1 && player[5] == 1 && player[8] == 1)
            return true;
        if (player[3] == 1 && player[6] == 1 && player[9] == 1)
            return true;
        if (player[1] == 1 && player[5] == 1 && player[9] == 1)
            return true;
        if (player[3] == 1 && player[5] == 1 && player[7] == 1)
            return true;
        return false;

    }

    void Start()
    {
        Debug.Log("游戏开始!\n");
    }
    void Update()
    {
        Debug.Log("游戏正在进行中!\n");

    }


    void OnGUI()
    {
        GUI.skin = Customer;
        GUI.BeginGroup(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 180, 600, 350));
       
        if (GUI.Button(new Rect(300,0 , 300, 350), message))
        {
            string temp = message;
            message = temp + "\n";
        }
        if (GUI.Button(new Rect(0, 240, 150, 110), "游戏帮助"))
        {
            string temp = message;
            message = temp + "\n(三个子连在一起你就赢了)";
        }

        if (GUI.Button(new Rect(150, 240, 150, 110), "退出游戏"))
        {
            Application.Quit();
        }
        GUI.Box(new Rect(0, 0, 300, 240), "井字棋");


        if (GUI.Button(new Rect(20, 20, 80, 60), string1))
        {
            if (selected[1] == 0)
            {
                if (count1 <= count2)
                {
                    string1 = "1";
                    player1[1] = 1;
                    count1++;
                    message = "轮到player2\n";
                }
                else
                {
                    string1 = "2";
                    player2[1] = 1;
                    count2++;
                    message = "轮到player1\n";
                }
                selected[1] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }

            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }


            // This code is executed when the Button is clicked
        }
        if (GUI.Button(new Rect(20, 95, 80, 60), string4))
        {
            if (selected[4] == 0)
            {
                if (count1 <= count2)
                {
                    string4 = "1";
                    player1[4] = 1;
                    count1++;
                    message = "轮到player2";
                }
                else
                {
                    string4 = "2";
                    player2[4] = 1;
                    count2++;
                    message = "轮到player1";
                }
                selected[4] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }
            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }
        }
        if (GUI.Button(new Rect(20, 170, 80, 60), string7))
        {
            if (selected[7] == 0)
            {
                if (count1 <= count2)
                {
                    string7 = "1";
                    player1[7] = 1;
                    count1++;
                    message = "轮到player2";
                }
                else
                {
                    string7 = "2";
                    player2[7] = 1;
                    count2++;
                    message = "轮到player1";
                }
                selected[7] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }
            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }
        }

        //2 column

        if (GUI.Button(new Rect(110, 20, 80, 60), string2))
        {
            if (selected[2] == 0)
            {
                if (count1 <= count2)
                {
                    string2 = "1";
                    player1[2] = 1;
                    count1++;
                    message = "轮到player2";
                }
                else
                {
                    string2 = "2";
                    player2[2] = 1;
                    count2++;
                    message = "轮到player1";
                }
                selected[2] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!";
                    GUI.backgroundColor = Color.red;

                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }
            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }
        }
        if (GUI.Button(new Rect(110, 95, 80, 60), string5))
        {
            if (selected[5] == 0)
            {
                if (count1 <= count2)
                {
                    string5 = "1";
                    player1[5] = 1;
                    count1++;
                    message = "轮到player2";
                }
                else
                {
                    string5 = "2";
                    player2[5] = 1;
                    count2++;
                    message = "轮到player1";
                }
                selected[5] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!";
                    GUI.backgroundColor = Color.red;

                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }
            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }
        }
        if (GUI.Button(new Rect(110, 170, 80, 60), string8))
        {
            if (selected[8] == 0)
            {
                if (count1 <= count2)
                {
                    string8 = "1";
                    player1[8] = 1;
                    count1++;
                    message = "轮到player2";
                }
                else
                {
                    string8 = "2";
                    player2[8] = 1;
                    count2++;
                    message = "轮到player1";
                }
                selected[8] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!";
                    GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!";
                    GUI.backgroundColor = Color.red;

                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }
            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }
        }


        //3column
        if (GUI.Button(new Rect(200, 20, 80, 60), string3))
        {
            if (selected[3] == 0)
            {
                if (count1 <= count2)
                {
                    string3 = "1";
                    player1[3] = 1;
                    count1++;
                    message = "轮到player2";
                }
                else
                {
                    string3 = "2";
                    player2[3] = 1;
                    count2++;
                    message = "轮到player1";
                }
                selected[3] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!"; GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!"; GUI.backgroundColor = Color.red;
                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }
            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }
        }
        if (GUI.Button(new Rect(200, 95, 80, 60), string6))
        {
            if (selected[6] == 0)
            {
                if (count1 <= count2)
                {
                    string6 = "1";
                    player1[6] = 1;
                    count1++;
                    message = "轮到player2";
                }
                else
                {
                    string6 = "2";
                    player2[6] = 1;
                    count2++;
                    message = "轮到player1";
                }
                selected[6] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!"; GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!"; GUI.backgroundColor = Color.red;
                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }
            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }
        }
        if (GUI.Button(new Rect(200, 170, 80, 60), string9))
        {
            if (selected[9] == 0)
            {
                if (count1 <= count2)
                {
                    string9 = "1";
                    player1[9] = 1;
                    count1++;
                    message = "轮到player2";
                }
                else
                {
                    string9 = "2";
                    player2[9] = 1;
                    count2++;
                    message = "轮到player1";
                }
                selected[9] = 1;

                if (Adjust(player1))
                {
                    message = "游戏结束：\nplayer1获胜!"; GUI.backgroundColor = Color.red;
                }
                if (Adjust(player2))
                {
                    message = "游戏结束：\nplayer2获胜!"; GUI.backgroundColor = Color.red;
                }
                if (!Adjust(player1) && !Adjust(player2) && count1 == 5)
                {
                    message = "游戏结束：\n和棋!";
                    GUI.backgroundColor = Color.red;
                }
            }
            else
            {
                message = "操作失败：\n这个地方已经有棋子了！";
            }
        }

        // End the group we started above. This is very important to remember!
        GUI.EndGroup();
    }



}