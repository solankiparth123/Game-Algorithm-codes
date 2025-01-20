/* first you make ui in unity we make dice game  add two button and text feild 
one button to roll dice and secound for reset 
first text is display score and secound desplay highscore */

/* create by Parth Solanki
insta:- im.parth.official*/

using unity Engine;
using unity Engine.UI;

public class Dice : MonoBehaviour{
    public Text Score;//for displaying the score so add one text object in the unity editor
    public Text HighScore //for displaying the high score so add one text object in the unity editor

    void start(){
        HighScore.text = PlayerPrefs.GetInt("HighScore",0).ToString(); 
    }

    public void RollDice(){
        int number = Random.Range(1,7);
        Score.text = number.ToString();

        if(number > PlayerPrefs.GetInt("HighScore",0)){
            PlayerPrefs.SetInt("HighScore",number);
            HighScore.text = number.ToString();
        }
        /* go in rolldice button and add script and after 
        go click event and dreg and drop this object and set  this roll dice method */
    }

    public void Reset(){
        PlayerPrefs.DeleteAll();
        HighScore.text="0";
        /* go in reset button and add script and after 
        go click event and dreg and drop this object and set  this reset method */
    }

}