using System;

namespace Character_input
{
    class Program
    {
        static int posX = 0;  
        static int posY = 0;

        static string lastPosPressed = "";

        //Arriba
        static void PressUp() {
            if (lastPosPressed == ""){
            lastPosPressed = "up";
            }
        }

        static void RelaseUp() {
            if (lastPosPressed == "up"){
                //Mover hacia arriba
                posY--;
                lastPosPressed = "";
            }
        }

        //Abajo
        static void PressDown(){
            if (lastPosPressed == ""){
            lastPosPressed = "down";
            }
        }

        static void RelaseDown() {
            if (lastPosPressed == "down"){
                //Mover hacia abajo
                posY++;
                lastPosPressed = "";
            }
        }

        //Derecha
        static void PressRight() {
            if (lastPosPressed == ""){
                lastPosPressed = "right";
            }
        }

        static void RelaseRight() {
            if (lastPosPressed == "right"){
                //Mover a la derecha
                posX++;
                lastPosPressed = "";
            }
        }

        //Izquierda
        static void PressLeft() {
            if (lastPosPressed == ""){
            lastPosPressed = "left";
            }
        }
        static void RelaseLeft() {
            if (lastPosPressed == "left"){
         //Mover a la izquierda
            posX--;
            lastPosPressed = "";
            }
        }

        static void Main(string[] args)
        {
        //   //Move up
        //   PressUp();
        //   RelaseUp();

        //   //Move right
        //   PressRight();
        //   PressDown();//ignored; right is already pressed
        //   RelaseRight();

        //   //Move right
        //   PressRight();
        //   RelaseRight();

          //Goto 500, -500
          for (int i = 0; i < 500; i++){
              //Move up
              PressUp();
              RelaseUp();

              //Move right
              PressRight();
              RelaseRight();
          }

          Console.WriteLine(posX+ "," + posY);



    }
 }
}


