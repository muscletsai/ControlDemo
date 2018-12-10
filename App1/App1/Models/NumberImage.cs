using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class NumberImage
    {
        public string StyleName { get; set; }
        public string Number0 { get; set; }
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public string Number3 { get; set; }
        public string Number4 { get; set; }
        public string Number5 { get; set; }
        public string Number6 { get; set; }
        public string Number7 { get; set; }
        public string Number8 { get; set; }
        public string Number9 { get; set; }
        public string Add { get; set; }
        public string Del { get; set; }
        public string Multiply { get; set; }
        public string Except { get; set; }
        public string Point { get; set; }
        public string Clear { get; set; }
        public string Tool { get; set; }
        public string Anser { get; set; }
        public string Back { get; set; }
        public string Percent { get; set; }

        public string GetVoice(string str)
        {
            string url = "http://taira-komori.jpn.org/sound_os/daily01/knocking_an_iron_door1.mp3";
            switch (str.ToUpper())
            {
                case "TOOL":

                    break;
                case "=":

                    break;
                case "+":

                    break;
                case "-":

                    break;
                case "*":

                    break;
                case "/":

                    break;
                case "%":

                    break;
                case "C":
                    url = "http://taira-komori.jpn.org/sound_os/daily02/cutting_papers1.mp3";
                    break;
                case "B":
                    url = "http://taira-komori.jpn.org/sound_os/daily02/scissors1.mp3";
                    break;
                case ".":
                    break;
                case "0":

                    break;

                case "1":
                  //  url = "https://www.youtube.com/audiolibrary_download?vid=8431026a91b21794";
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                case "7":

                    break;
                case "8":

                    break;
                case "9":

                    break;
            }
            return url;
        }
    }


}
