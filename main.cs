public class Letters
{
   private char[,] asterixBlock;
   private const int ROWS = 10;
   private const int COLS = 10;
   private string filename = "C:\\temp\\MyFile.txt";
   StreamWriter output;
   /*
    * default constructor
    * This method initializes the 2 dimensional array asteriskBlock
    */
   public Letters()
   {
      asterixBlock = new char[ROWS, COLS] { {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} ,
                                              {'*','*','*','*','*','*','*','*','*','*'} };
   }

   /*
    * displayLetterO
    * This method displays the letter O in asterisk
    * It uses the 2 dimensional array asterixBlock
    */
   public void writeLetterO()
   {
      output = new StreamWriter(filename);
      for (int r = 0; r < ROWS; r++) //loop for each row
      {
         for (int c = 0; c < COLS; c++) //loop for each column
         {
            if (r == 0) //first row
            {
               if (c == 2) //fourth column
               {
                  output.Write(asterixBlock[r, c]); //display asterisk
                  Console.Write(asterixBlock[r, c]);
               }

               else
                  output.Write(" "); //display space
            }

            if (r == 1) //second row
            {
               if (c == 2) //second column
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }

            if (r == 2)
            {
               if (c == 2)
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }

            if (r == 3)
            {
               if (c == 2)
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }

            if (r == 4)
            {
               if (c == 2)
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }

            if (r == 5)
            {
               if (c == 2)
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }

            if (r == 6)
            {
               if (c == 2)
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }

            if (r == 7)
            {
               if (c == 2)
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }

            if (r == 8)
            {
               if (c == 2) //second column
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }

            if (r == 9)
            {
               if (c == 2)
                  output.Write(asterixBlock[r, c]);
               else if (c == 3) //fourth column
                  output.Write(asterixBlock[r, c]); //display asterisk

               else if (c == 4) //fifth column
                  output.Write(asterixBlock[r, c]); //display asterisk

               else if (c == 5) //sixth column
                  output.Write(asterixBlock[r, c]); //display asterisk

               else if (c == 6) //seventh column
                  output.Write(asterixBlock[r, c]); //display asterisk

               else
                  output.Write(" "); //display space
            }
            
         }
         output.WriteLine();
          //end of row, add new line
      }
      output.Close();
   } //end of displayLetterO
}

public class LetterTest
{
   public static void Main(string[] args)
   {
      Letters alphabetSoup = new Letters();

      alphabetSoup.writeLetterO();
      
   }
}
